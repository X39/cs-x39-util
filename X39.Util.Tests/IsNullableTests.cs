using NUnit.Framework;
using X39.Util.Tests.MemberInfoExtensions;

namespace X39.Util.Tests;

public class IsNullableTests
{
    [Test]
    public void NullableEnabledClassWithMixedNullabilityMethodTest()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NullableMethod()).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NotNullableMethod()).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithMixedNullabilityPropertyTest()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NullableProperty).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NotNullableProperty).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithMixedNullabilityFieldTest()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NullableField).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NotNullableField).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithNullableContentOnly()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledNullable>(c => c.NullableMethod()).IsNullable());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledNullable>(c => c.NullableProperty).IsNullable());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledNullable>(c => c.NullableField).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithNotNullableContentOnly()
    {
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod()).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledNotNullable>(c => c.NotNullableProperty).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledNotNullable>(c => c.NotNullableField).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithSingleNullable()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledSingleNullable>(c => c.NullableField).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithSingleNotNullable()
    {
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledSingleNotNullable>(c => c.NotNullableField).IsNullable());
    }
    
    
    
    
    
    [Test]
    public void NullableDisabledClassWithMixedNullabilityMethodTest()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NullableMethod()).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableEnabledMixed>(c => c.NotNullableMethod()).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithMixedNullabilityPropertyTest()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableDisabledMixed>(c => c.NullableProperty).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableDisabledMixed>(c => c.NotNullableProperty).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithMixedNullabilityFieldTest()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableDisabledMixed>(c => c.NullableField).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableDisabledMixed>(c => c.NotNullableField).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithNullableContentOnly()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableDisabledNullable>(c => c.NullableMethod()).IsNullable());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableDisabledNullable>(c => c.NullableProperty).IsNullable());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableDisabledNullable>(c => c.NullableField).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithNotNullableContentOnly()
    {
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod()).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableDisabledNotNullable>(c => c.NotNullableProperty).IsNullable());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableDisabledNotNullable>(c => c.NotNullableField).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithSingleNullable()
    {
        Assert.IsTrue(TestHelpers.GetMemberInfo<NullableDisabledSingleNullable>(c => c.NullableField).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithSingleNotNullable()
    {
        Assert.IsFalse(TestHelpers.GetMemberInfo<NullableDisabledSingleNotNullable>(c => c.NotNullableField).IsNullable());
    }
}