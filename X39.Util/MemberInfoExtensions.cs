using System.Reflection;

namespace X39.Util;

/// <summary>
/// Class containing extension methods relating to the <see cref="MemberInfo"/> type.
/// </summary>
[PublicAPI]
public static class MemberInfoExtensions{
    
    /// <summary>
    /// Receive the actual <see cref="GetMemberType"/> represented by the <see cref="MemberInfo"/>.
    /// </summary>
    /// <param name="memberInfo">The member info to get the <see cref="Type"/> of.</param>
    /// <returns>
    /// Depending on the actual input class:
    /// <list type="bullet">
    /// <item><see cref="PropertyInfo"/>: The value of <see cref="PropertyInfo.PropertyType"/>.</item>
    /// <item><see cref="FieldInfo"/>: The value of <see cref="FieldInfo.FieldType"/>.</item>
    /// <item><see cref="MethodInfo"/>: The value of <see cref="MethodInfo.ReturnType"/>.</item>
    /// </list>
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the <see cref="MemberInfo"/> overload is not known.
    /// </exception>
    public static Type GetMemberType(this MemberInfo memberInfo)
    {
        return memberInfo switch
        {
            PropertyInfo propertyInfo => propertyInfo.PropertyType,
            FieldInfo fieldInfo => fieldInfo.FieldType,
            MethodInfo methodInfo => methodInfo.ReturnType,
            _ => throw new InvalidOperationException(
                $"Unknown MemberInfo type {memberInfo.GetType().FullName()}. " +
                "Please raise an issue at https://github.com/X39/cs-x39-util/issues")
        };
        
    }
}