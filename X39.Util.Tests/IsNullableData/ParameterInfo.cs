// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBeMadeStatic.Global
#pragma warning disable CS8632
#pragma warning disable CS8618
#pragma warning disable CA1822
namespace X39.Util.Tests.IsNullableData.ParameterInfo;

#nullable enable
public class NullableEnabledMixed
{
    public string? NullableMethod(object? nullableA, object? nullableB, object? nullableC) => default;
    public string? MixedMethod(object a, object? nullableB, object c) => default;
    public string MixedMethodInverse(object? nullableA, object b, object? nullableC) => string.Empty;
    public string NotNullableMethod(object a, object b, object c) => string.Empty;
}

public class NullableEnabledNullable
{
    public string? NullableMethod1(object? nullableA, object? nullableB, object? nullableC) => default;
    public string? NullableMethod2(object? nullableA, object? nullableB, object? nullableC) => default;
    public string? NullableMethod3(object? nullableA, object? nullableB, object? nullableC) => default;
}

public class NullableEnabledNotNullable
{
    public string NotNullableMethod1(object a, object b, object c) => string.Empty;
    public string NotNullableMethod2(object a, object b, object c) => string.Empty;
    public string NotNullableMethod3(object a, object b, object c) => string.Empty;
}

public class NullableEnabledSingleNullable
{
    public string? NullableMethod(object? nullableA, object? nullableB, object? nullableC) => default;
}

public class NullableEnabledSingleNotNullable
{
    public string NotNullableMethod(object a, object b, object c) => string.Empty;
}

#nullable disable
public class NullableDisabledMixed
{
    public string? NullableMethod(object? nullableA, object? nullableB, object? nullableC) => default;
    public string? MixedMethod(object a, object? nullableB, object c) => default;
    public string MixedMethodInverse(object? nullableA, object b, object? nullableC) => string.Empty;
    public string NotNullableMethod(object a, object b, object c) => string.Empty;
}

public class NullableDisabledNullable
{
    public string? NullableMethod1(object? nullableA, object? nullableB, object? nullableC) => default;
    public string? NullableMethod2(object? nullableA, object? nullableB, object? nullableC) => default;
    public string? NullableMethod3(object? nullableA, object? nullableB, object? nullableC) => default;
}

public class NullableDisabledNotNullable
{
    public string NotNullableMethod1(object a, object b, object c) => string.Empty;
    public string NotNullableMethod2(object a, object b, object c) => string.Empty;
    public string NotNullableMethod3(object a, object b, object c) => string.Empty;
}

public class NullableDisabledSingleNullable
{
    public string? NullableMethod(object? nullableA, object? nullableB, object? nullableC) => default;
}

public class NullableDisabledSingleNotNullable
{
    public string NotNullableMethod(object a, object b, object c) => string.Empty;
}