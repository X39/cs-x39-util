#nullable enable
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using X39.Util.Collections.Concurrent;

namespace X39.Util;

[PublicAPI]
public static partial class MemberInfoExtensionMethods
{
    
    // ReSharper disable once IdentifierTypo
    private static readonly RWLConcurrentDictionary<MemberInfo, bool> IsNullableCache = new();
    private static readonly RWLConcurrentDictionary<MemberInfo, bool> IsObsoleteCache = new();

    /// <summary>
    /// Clears all cached data for the methods provided by <see cref="MemberInfoExtensionMethods"/>. 
    /// </summary>
    public static void ClearCache()
    {
        IsNullableCache.Clear();
        IsObsoleteCache.Clear();
    }
    
    private const string FullNameOfNullableAttribute = "System.Runtime.CompilerServices.NullableAttribute";
    private const string FullNameOfNullableContextAttribute = "System.Runtime.CompilerServices.NullableContextAttribute";
    private const string FieldFlagOfNullableContext = "Flag";
    private const string FieldNullableFlagsOfNullable = "NullableFlags";

    /// <summary>
    /// Checks whether a member is nullable or not.
    /// This expects nullable reference types to be enabled,
    /// which means that nullable references which are not properly annotated will return false.
    /// </summary>
    /// <param name="memberInfo">The member to check.</param>
    /// <param name="useCache">
    ///     If <see langword="true"/>, the reflection lookup will be performed once and successive calls are served
    ///     from a cache.
    ///     If <see langword="false"/>, the reflection lookup is performed every time.
    /// </param>
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
    public static bool IsNullable(this MemberInfo memberInfo, bool useCache = true)
    {
        byte GetNullableReferenceContextFlag(object? nullableContextAttribute)
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

        byte[] GetNullableFlags(object? nullableAttribute)
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

        bool CheckNullableViaReflection()
        {
            var actualType = memberInfo switch
            {
                PropertyInfo propertyInfo => propertyInfo.PropertyType,
                FieldInfo fieldInfo => fieldInfo.FieldType,
                MethodInfo methodInfo => methodInfo.ReturnType,
                _ => throw new InvalidOperationException(
                    $"Unknown MemberInfo type {memberInfo.GetType().FullName()}. " +
                    "Please raise an issue at https://github.com/X39/cs-x39-util/issues")
            };

            if (actualType.IsGenericType(typeof(Nullable<>)))
                return true;
            var nullableAttributeOfMember = memberInfo.GetCustomAttributes()
                .FirstOrDefault((attribute) => attribute.GetType().FullName == FullNameOfNullableAttribute);
            if (GetNullableFlags(nullableAttributeOfMember).DefaultIfEmpty<byte>(0).All((q) => q is 2))
                return true;
            var memberInfoNullableContextAttribute = memberInfo.GetCustomAttributes().FirstOrDefault(
                (attribute) => attribute.GetType().FullName == FullNameOfNullableContextAttribute);
            if (GetNullableReferenceContextFlag(memberInfoNullableContextAttribute) is 2)
                return true;
            var declaringType = memberInfo.DeclaringType
#pragma warning disable CA2201
                                ?? throw new NullReferenceException(
                                    $"Declaring type is null. " +
                                    "Please raise an issue at https://github.com/X39/cs-x39-util/issues");
#pragma warning restore CA2201
            var declaringTypeNullableContextAttribute = declaringType.GetCustomAttributes().FirstOrDefault(
                (attribute) => attribute.GetType().FullName == FullNameOfNullableContextAttribute);
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (GetNullableReferenceContextFlag(declaringTypeNullableContextAttribute) is 2)
                return true;
            return false;
        }

        return useCache switch
        {
            true when IsNullableCache.TryGetValue(memberInfo, out var isNullable) => isNullable,
            true => IsNullableCache[memberInfo] = CheckNullableViaReflection(),
            _ => CheckNullableViaReflection()
        };
    }

    /// <summary>
    /// Checks if the given <paramref name="memberInfo"/> has the <see cref="ObsoleteAttribute"/> placed and hence is
    /// considered obsolete.
    /// </summary>
    /// <remarks>
    /// This method will return <see langword="true"/> if the declaring <see langword="class"/> is marked with the
    /// <see cref="ObsoleteAttribute"/> but the actual member is not.
    /// Be aware tho that this won't work for the get and set methods of a property when the property is marked
    /// with the <see cref="ObsoleteAttribute"/>. The get and set methods only will be reported as obsolete if
    /// the getter/setter itself is marked as obsolete or the class is marked obsolete. They will not report as
    /// obsolete if only the property is marked as obsolete. The same applies for nested classes.
    ///
    /// This may change in the future but requires a full scan of a class.
    /// </remarks>
    /// <param name="memberInfo">The <see cref="MemberInfo"/> to check.</param>
    /// <param name="useCache">
    ///     If <see langword="true"/>, the reflection lookup will be performed once and successive calls are served
    ///     from a cache.
    ///     If <see langword="false"/>, the reflection lookup is performed every time.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <paramref name="memberInfo"/> is obsolete, <see langword="false"/> if not.
    /// </returns>
    public static bool IsObsolete(this MemberInfo memberInfo, bool useCache = true)
    {
        if (useCache && IsObsoleteCache.TryGetValue(memberInfo, out var flag))
            return flag;
        var attribute = memberInfo.GetCustomAttribute<ObsoleteAttribute>();
        var tmp = attribute is not null;
        if (tmp is false && memberInfo.DeclaringType?.IsObsolete(useCache: useCache) is {} classObsolete)
            tmp = classObsolete;
        if (useCache)
            IsObsoleteCache[memberInfo] = tmp;
        return tmp;
    }
}