#if NET7_0_OR_GREATER
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using NUnit.Framework;

namespace X39.Util.Tests;

public class CreateInstanceViaJsonSerializerTest
{
    #region SerializerTest

    public class PrimitivePair
    {
        public PrimitiveString String { get; set; }
        public PrimitiveUShort UShort { get; set; }
    }

    public class StronglyTypedPrimitiveConverterFactory : JsonConverterFactory
    {
#pragma warning disable CS0618
        private interface ICreator
        {
            public object Value { get; }
        }

        private class Creator<TType, TPrimitive> : ICreator
            where TType : IStronglyTypedPrimitive<TType, TPrimitive>, new()
        {
            public object Value { get; }

            public Creator(TPrimitive primitive)
            {
                Value = new TType {Value = primitive};
            }
        }

        private class StronglyTypedPrimitiveConverter<TType, TPrimitive> : JsonConverter<TType>
            where TType : IStronglyTypedPrimitive<TType, TPrimitive>, new()
        {
            public override TType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (!IsPrimitiveTokenType(reader.TokenType))
                    return JsonSerializer.Deserialize<TType>(ref reader);

                if (typeof(TPrimitive).IsEquivalentTo(typeof(string)))
                {
                    var value = reader.GetString() ?? string.Empty;

                    return (TType) typeof(Creator<,>)
                        .MakeGenericType(typeof(TType), typeof(string))
                        .CreateInstanceWith<ICreator>(value)
                        .Value;
                }

                if (typeof(TPrimitive).IsEquivalentTo(typeof(ushort)))
                {
                    var value = reader.GetUInt16();

                    return (TType) typeof(Creator<,>)
                        .MakeGenericType(typeof(TType), typeof(ushort))
                        .CreateInstanceWith<ICreator>(value)
                        .Value;
                }

                throw new NotSupportedException($"The primitive {typeof(TPrimitive).FullName()} is not supported");
            }

            public override void Write(Utf8JsonWriter writer, TType value, JsonSerializerOptions options)
            {
                switch (value.Value)
                {
                    case string stringValue:
                        writer.WriteStringValue(stringValue);
                        break;
                    case ushort ushortValue:
                        writer.WriteNumberValue(ushortValue);
                        break;
                    default:
                        throw new NotSupportedException(
                            $"The primitive {typeof(TPrimitive).FullName()} is not supported");
                }
            }

            private static bool IsPrimitiveTokenType(JsonTokenType tokenType)
            {
                return tokenType is
                    JsonTokenType.String or
                    JsonTokenType.Number;
            }
        }

        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IStronglyTypedPrimitive).IsAssignableFrom(typeToConvert);
        }

        /// <inheritdoc />
        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var interfaceType = typeToConvert.GetInterfaces()
                .First((q) => q.IsGenericType(typeof(IStronglyTypedPrimitive<,>)));
            return typeof(StronglyTypedPrimitiveConverter<,>)
                .MakeGenericType(interfaceType.GetGenericArguments())
                .CreateInstanceWith<JsonConverter>();
        }
#pragma warning restore CS0618
    }

    public interface IStronglyTypedPrimitive
    {
    }

#pragma warning disable CS0618
    public interface IStronglyTypedPrimitive<TType, TPrimitive> : IStronglyTypedPrimitive
        where TType : IStronglyTypedPrimitive<TType, TPrimitive>, new()
#pragma warning restore CS0618
    {
        public TPrimitive Value { get; init; }
    }

    public readonly struct PrimitiveString : IStronglyTypedPrimitive<PrimitiveString, string>
    {
        public PrimitiveString(string value)
        {
            Value = value;
        }

        public string Value { get; init; }
    }

    public readonly struct PrimitiveUShort : IStronglyTypedPrimitive<PrimitiveUShort, ushort>
    {
        public PrimitiveUShort(ushort value)
        {
            Value = value;
        }

        public ushort Value { get; init; }
    }

    #endregion

    [Test]
    public void Test()
    {
        const string json = "{\"String\":\"AB\",\"UShort\":123}";

        for (var i = 0; i < 1000; i++)
        {
            JsonSerializer.Deserialize<PrimitivePair>(json, new JsonSerializerOptions
            {
                Converters =
                {
                    new StronglyTypedPrimitiveConverterFactory()
                }
            });
        }

        Assert.AreEqual(4, TypeExtensionMethods.CreateInstanceCache.Count);
    }
}


#endif