// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBeMadeStatic.Global
#pragma warning disable CS8632
#pragma warning disable CS8618
#pragma warning disable CA1822
namespace X39.Util.Tests.MemberInfoExtensions;

#nullable enable
public class NullableEnabledMixed
{
    public string? NullableMethod()
    {
        return default;
    }

    public string NotNullableMethod()
    {
        return default!;
    }

    public string? NullableProperty { get; set; }
    public string NotNullableProperty { get; set; }
    public string? NullableField;
    public string NotNullableField;
}

public class NullableEnabledNullable
{
    public string? NullableMethod()
    {
        return default;
    }

    public string? NullableProperty { get; set; }
    public string? NullableField;
}

public class NullableEnabledNotNullable
{
    public string NotNullableMethod()
    {
        return default!;
    }

    public string NotNullableProperty { get; set; }
    public string NotNullableField;
}

public class NullableEnabledSingleNullable
{
    public string? NullableField;
}

public class NullableEnabledSingleNotNullable
{
    public string NotNullableField;
}

#nullable disable
public class NullableDisabledMixed
{
    public string? NullableMethod()
    {
        return default;
    }

    public string NotNullableMethod()
    {
        return default!;
    }

    public string? NullableProperty { get; set; }
    public string NotNullableProperty { get; set; }
    public string? NullableField;
    public string NotNullableField;
}

public class NullableDisabledNullable
{
    public string? NullableMethod()
    {
        return default;
    }

    public string? NullableProperty { get; set; }
    public string? NullableField;
}

public class NullableDisabledNotNullable
{
    public string NotNullableMethod()
    {
        return default!;
    }

    public string NotNullableProperty { get; set; }
    public string NotNullableField;
}

public class NullableDisabledSingleNullable
{
    public string? NullableField;
}

public class NullableDisabledSingleNotNullable
{
    public string NotNullableField;
}