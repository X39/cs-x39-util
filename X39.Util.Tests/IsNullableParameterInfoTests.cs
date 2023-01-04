using NUnit.Framework;
using X39.Util.Tests.IsNullableData.ParameterInfo;

namespace X39.Util.Tests;


public class IsNullableParameterInfoTests
{
    [Test]
    public void NullableEnabledClassWithMixedNullabilityParametersTest()
    {
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.NullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.NullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.NullableMethod(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.MixedMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.MixedMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.MixedMethod(default!, default!, default!), 2).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.MixedMethodInverse(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.MixedMethodInverse(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.MixedMethodInverse(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.NotNullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.NotNullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledMixed>(c => c.NotNullableMethod(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithNullableParametersOnly()
    {
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod1(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod1(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod1(default!, default!, default!), 2).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod2(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod2(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod2(default!, default!, default!), 2).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod3(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod3(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledNullable>(c => c.NullableMethod3(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithNotNullableParametersOnly()
    {
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod1(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod1(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod1(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod2(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod2(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod2(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod3(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod3(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledNotNullable>(c => c.NotNullableMethod3(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithSingleNullable()
    {
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledSingleNullable>(c => c.NullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledSingleNullable>(c => c.NullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableEnabledSingleNullable>(c => c.NullableMethod(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableEnabledClassWithSingleNotNullable()
    {
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledSingleNotNullable>(c => c.NotNullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledSingleNotNullable>(c => c.NotNullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableEnabledSingleNotNullable>(c => c.NotNullableMethod(default!, default!, default!), 2).IsNullable());
    }
    
    
    
    
    
    [Test]
    public void NullableDisabledClassWithMixedNullabilityParametersTest()
    {
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.NullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.NullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.NullableMethod(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.MixedMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.MixedMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.MixedMethod(default!, default!, default!), 2).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.MixedMethodInverse(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.MixedMethodInverse(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.MixedMethodInverse(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.NotNullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.NotNullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledMixed>(c => c.NotNullableMethod(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithNullableParametersOnly()
    {
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod1(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod1(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod1(default!, default!, default!), 2).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod2(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod2(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod2(default!, default!, default!), 2).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod3(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod3(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledNullable>(c => c.NullableMethod3(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithNotNullableParametersOnly()
    {
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod1(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod1(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod1(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod2(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod2(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod2(default!, default!, default!), 2).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod3(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod3(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledNotNullable>(c => c.NotNullableMethod3(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithSingleNullable()
    {
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledSingleNullable>(c => c.NullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledSingleNullable>(c => c.NullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsTrue(TestHelpers.GetParameterInfo<NullableDisabledSingleNullable>(c => c.NullableMethod(default!, default!, default!), 2).IsNullable());
    }
    [Test]
    public void NullableDisabledClassWithSingleNotNullable()
    {
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledSingleNotNullable>(c => c.NotNullableMethod(default!, default!, default!), 0).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledSingleNotNullable>(c => c.NotNullableMethod(default!, default!, default!), 1).IsNullable());
        Assert.IsFalse(TestHelpers.GetParameterInfo<NullableDisabledSingleNotNullable>(c => c.NotNullableMethod(default!, default!, default!), 2).IsNullable());
    }
}