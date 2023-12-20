using NUnit.Framework;

namespace X39.Util.Tests.TypeExtensionMethods;

[TestFixture]
public class FullNameTest
{
    
    [Test]
    public void NormalClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass", typeof(Data.NormalClass).FullNameUncached());
    }

    [Test]
    public void NormalClassSubClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClass", typeof(Data.NormalClass.SubClass).FullNameUncached());
    }
    [Test]
    public void NormalClassSubClassSubSubClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClass.SubSubClass", typeof(Data.NormalClass.SubClass.SubSubClass).FullNameUncached());
    }

    [Test]
    public void NormalClassSubClassGenericTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<T1, T2, T3>", typeof(Data.NormalClass.SubClassGeneric<,,>).FullNameUncached());
    }
    [Test]
    public void NormalClassSubClassGenericSubSubClassGenericTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<T1, T2, T3>.SubSubClassGeneric<T1>", typeof(Data.NormalClass.SubClassGeneric<,,>.SubSubClassGeneric<>).FullNameUncached());
    }
    [Test]
    public void GenericClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>", typeof(Data.GenericClass<,,>).FullNameUncached());
    }
    [Test]
    public void GenericClassTestSubClass()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>", typeof(Data.GenericClass<,,>.SubClass).FullNameUncached());
    }
    [Test]
    public void GenericClassTestSubClassSubSubClass()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>", typeof(Data.GenericClass<,,>.SubClass.SubSubClass).FullNameUncached());
    }
    [Test]
    public void GenericClassTestSubClassGenericTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<T1, T2, T3>", typeof(Data.GenericClass<,,>.SubClassGeneric<,,>).FullNameUncached());
    }
    [Test]
    public void GenericClassTestSubClassGenericSubSubClassGenericTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<T1, T2, T3>.SubSubClassGeneric<T1>", typeof(Data.GenericClass<,,>.SubClassGeneric<,,>.SubSubClassGeneric<>).FullNameUncached());
    }
}