using System.Reflection;

namespace X39.Util;

public static class ReflectionNullableExtensions
{
    private const string FullNameOfNullableAttribute = "System.Runtime.CompilerServices.NullableAttribute";

    private const string FullNameOfNullableContextAttribute =
        "System.Runtime.CompilerServices.NullableContextAttribute";

    private const string FieldFlagOfNullableContext = "Flag";

    private const string FieldNullableFlagsOfNullable = "NullableFlags";

    /// <summary>
    /// Checks whether a member is nullable or not.
    /// This expects nullable reference types to be enabled,
    /// which means that nullable references which are not properly annotated will return false.
    /// </summary>
    /// <remarks>
    /// This function is not caching the result. Caching tho is highly recommended at calling method.
    /// </remarks>
    /// <param name="memberInfo">The member to check.</param>
    /// <returns>True if the member is nullable, false if not.</returns>
    /// <exception cref="NullReferenceException">
    /// Thrown if any expected reflective value is null.
    /// If this gets raised, please escalate the exception to https://github.com/X39/cs-x39-util/issues
    /// </exception>
    /// <exception cref="InvalidCastException">
    /// Thrown when any expected reflective value is not of the expected type.
    /// If this gets raised, please escalate the exception to https://github.com/X39/cs-x39-util/issues
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the <see cref="MemberInfo"/> contains data that cannot be properly extracted.
    /// If this gets raised, please escalate the exception to https://github.com/X39/cs-x39-util/issues
    /// </exception>
    public static bool IsNullable(this MemberInfo memberInfo)
    {
        var actualType = memberInfo.GetMemberType();

        if (actualType.IsGenericType(typeof(Nullable<>)))
            return true;
        if (IsMemberInfoNullable(memberInfo))
            return true;
        var declaringType = GetDeclaringType(memberInfo);
        if (IsDeclaringTypeNullable(declaringType))
            return true;
        return false;
    }

    /// <summary>
    /// Checks whether a parameter is nullable or not.
    /// This expects nullable reference types to be enabled,
    /// which means that nullable references which are not properly annotated will return false.
    /// </summary>
    /// <remarks>
    /// This function is not caching the result. Caching tho is highly recommended at calling method.
    /// </remarks>
    /// <param name="parameterInfo">The parameter to check.</param>
    /// <returns>True if the member is nullable, false if not.</returns>
    /// <exception cref="NullReferenceException">
    /// Thrown if any expected reflective value is null.
    /// If this gets raised, please escalate the exception to https://github.com/X39/cs-x39-util/issues
    /// </exception>
    /// <exception cref="InvalidCastException">
    /// Thrown when any expected reflective value is not of the expected type.
    /// If this gets raised, please escalate the exception to https://github.com/X39/cs-x39-util/issues
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the <see cref="MemberInfo"/> contains data that cannot be properly extracted.
    /// If this gets raised, please escalate the exception to https://github.com/X39/cs-x39-util/issues
    /// </exception>
    public static bool IsNullable(this ParameterInfo parameterInfo)
    {
        var actualType = parameterInfo.ParameterType;

        if (actualType.IsGenericType(typeof(Nullable<>)))
            return true;
        if (IsParameterInfoNullable(parameterInfo))
            return true;
        var memberInfo = parameterInfo.Member;
        if (IsMemberInfoNullable(memberInfo))
            return true;
        var declaringType = GetDeclaringType(memberInfo);
        if (IsDeclaringTypeNullable(declaringType))
            return true;
        return false;
    }

    private static Type GetDeclaringType(MemberInfo memberInfo)
    {
        var declaringType = memberInfo.DeclaringType
#pragma warning disable CA2201
                            ?? throw new NullReferenceException(
                                $"Declaring type is null. " +
                                "Please raise an issue at https://github.com/X39/cs-x39-util/issues");
#pragma warning restore CA2201
        return declaringType;
    }

    private static bool IsParameterInfoNullable(ParameterInfo parameterInfo)
    {
        var nullableAttributeOfMember = parameterInfo.GetCustomAttributes()
            .FirstOrDefault((attribute) => attribute.GetType().FullName == FullNameOfNullableAttribute);
        if (GetNullableFlagsFromNullableAttribute(nullableAttributeOfMember).DefaultIfEmpty<byte>(0).All((q) => q is 2))
            return true;
        var memberInfoNullableContextAttribute = parameterInfo.GetCustomAttributes().FirstOrDefault(
            (attribute) => attribute.GetType().FullName == FullNameOfNullableContextAttribute);
        if (GetFlagValueFromNullableContextAttribute(memberInfoNullableContextAttribute) is 2)
            return true;
        return false;
    }

    private static bool IsMemberInfoNullable(MemberInfo memberInfo)
    {
        var nullableAttributeOfMember = memberInfo.GetCustomAttributes()
            .FirstOrDefault((attribute) => attribute.GetType().FullName == FullNameOfNullableAttribute);
        if (GetNullableFlagsFromNullableAttribute(nullableAttributeOfMember).DefaultIfEmpty<byte>(0).All((q) => q is 2))
            return true;
        var memberInfoNullableContextAttribute = memberInfo.GetCustomAttributes().FirstOrDefault(
            (attribute) => attribute.GetType().FullName == FullNameOfNullableContextAttribute);
        if (GetFlagValueFromNullableContextAttribute(memberInfoNullableContextAttribute) is 2)
            return true;
        return false;
    }

    private static bool IsDeclaringTypeNullable(Type declaringType)
    {
        var declaringTypeNullableContextAttribute = declaringType.GetCustomAttributes().FirstOrDefault(
            (attribute) => attribute.GetType().FullName == FullNameOfNullableContextAttribute);
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (GetFlagValueFromNullableContextAttribute(declaringTypeNullableContextAttribute) is 2)
            return true;
        return false;
    }

    private static byte[] GetNullableFlagsFromNullableAttribute(object? nullableAttribute)
    {
        if (nullableAttribute is null)
            return Array.Empty<byte>();
        var flagField = nullableAttribute.GetType().GetField(FieldNullableFlagsOfNullable);
        if (flagField is null)
#pragma warning disable CA2201
            throw new NullReferenceException(
                $"Failed to get {FieldNullableFlagsOfNullable} field of {FullNameOfNullableAttribute}. " +
                $"Please raise an issue at https://github.com/X39/cs-x39-util/issues");
#pragma warning restore CA2201
        var flagValue = flagField.GetValue(nullableAttribute);
        if (flagValue is byte[] b)
            return b;
        throw new InvalidCastException(
            "Flag value is not of the expected type byte[]. " +
            "Please raise an issue at https://github.com/X39/cs-x39-util/issues");
    }

    private static byte GetFlagValueFromNullableContextAttribute(object? nullableContextAttribute)
    {
        if (nullableContextAttribute is null)
            return 0;
        var flagField = nullableContextAttribute.GetType().GetField(FieldFlagOfNullableContext);
        if (flagField is null)
#pragma warning disable CA2201
            throw new NullReferenceException(
                $"Failed to get {FieldFlagOfNullableContext} field of {FullNameOfNullableContextAttribute}. " +
                $"Please raise an issue at https://github.com/X39/cs-x39-util/issues");
#pragma warning restore CA2201
        var flagValue = flagField.GetValue(nullableContextAttribute);
        if (flagValue is byte b)
            return b;
        throw new InvalidCastException(
            "Flag value is not of the expected type byte. " +
            "Please raise an issue at https://github.com/X39/cs-x39-util/issues");
    }
}