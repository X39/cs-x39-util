using System.Collections.Generic;
using NUnit.Framework;

namespace X39.Util.Tests.TypeExtensionMethods;

[TestFixture]
public class FullNameTest
{
    [Test]
    public void DictionaryTestUntyped()
    {
        Assert.AreEqual("System.Collections.Generic.Dictionary<TKey, TValue>",
            typeof(System.Collections.Generic.Dictionary<,>).FullNameUncached());
    }

    [Test]
    public void DictionaryTestTyped()
    {
        Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, System.Int32>",
            typeof(System.Collections.Generic.Dictionary<string, int>).FullNameUncached());
    }


    [Test]
    public void ComplexDictionaryTestTyped()
    {
        Assert.AreEqual(
            "System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>",
            typeof(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>>)
                .FullNameUncached());
    }

    [Test]
    public void NestedGenericClassTest()
    {
        Assert.AreEqual(
            "X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<System.String, X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<System.String, System.String, System.String>, System.Int32>",
            typeof(Data.GenericClass<string, Data.GenericClass<string,string,string>, int>).FullNameUncached());
    }

    [Test]
    public void ComplexNestedGenericInNormalClassTest()
    {
        Assert.AreEqual(
            "X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<System.String, X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<System.String, System.String, System.String>, System.Int32>",
            typeof(Data.NormalClass.SubClassGeneric<string, Data.GenericClass<string,string,string>, int>).FullNameUncached());
    }

    [Test]
    public void NormalClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass",
            typeof(Data.NormalClass).FullNameUncached());
    }

    [Test]
    public void NormalClassSubClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClass",
            typeof(Data.NormalClass.SubClass).FullNameUncached());
    }

    [Test]
    public void NormalClassSubClassSubSubClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClass.SubSubClass",
            typeof(Data.NormalClass.SubClass.SubSubClass).FullNameUncached());
    }

    [Test]
    public void NormalClassSubClassGenericTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<T1, T2, T3>",
            typeof(Data.NormalClass.SubClassGeneric<,,>).FullNameUncached());
    }

    [Test]
    public void NormalClassSubClassGenericSubSubClassGenericTest()
    {
        Assert.AreEqual(
            "X39.Util.Tests.TypeExtensionMethods.Data.NormalClass.SubClassGeneric<T1, T2, T3>.SubSubClassGeneric<T1>",
            typeof(Data.NormalClass.SubClassGeneric<,,>.SubSubClassGeneric<>).FullNameUncached());
    }

    [Test]
    public void GenericClassTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>",
            typeof(Data.GenericClass<,,>).FullNameUncached());
    }

    [Test]
    public void GenericClassTestSubClass()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>.SubClass",
            typeof(Data.GenericClass<,,>.SubClass).FullNameUncached());
    }

    [Test]
    public void GenericClassTestSubClassSubSubClass()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>.SubClass.SubSubClass",
            typeof(Data.GenericClass<,,>.SubClass.SubSubClass).FullNameUncached());
    }

    [Test]
    public void GenericClassTestSubClassGenericTest()
    {
        Assert.AreEqual("X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>.SubClassGeneric<T1, T2, T3>",
            typeof(Data.GenericClass<,,>.SubClassGeneric<,,>).FullNameUncached());
    }

    [Test]
    public void GenericClassTestSubClassGenericSubSubClassGenericTest()
    {
        Assert.AreEqual(
            "X39.Util.Tests.TypeExtensionMethods.Data.GenericClass<T1, T2, T3>.SubClassGeneric<T1, T2, T3>.SubSubClassGeneric<T1>",
            typeof(Data.GenericClass<,,>.SubClassGeneric<,,>.SubSubClassGeneric<>).FullNameUncached());
    }

    [Test]
    [NonParallelizable]
    public void ValidateCacheWorks()
    {
        Util.TypeExtensionMethods.FullNameCache.Clear();
        Assert.AreEqual(Util.TypeExtensionMethods.FullNameCache.Count, 0);
        typeof(Data.GenericClass<,,>).FullNameUncached();
        Assert.AreEqual(Util.TypeExtensionMethods.FullNameCache.Count, 0);
        typeof(Data.GenericClass<,,>).FullName();
        Assert.AreEqual(Util.TypeExtensionMethods.FullNameCache.Count, 1);
        typeof(Data.GenericClass<,,>).FullName();
        Assert.AreEqual(Util.TypeExtensionMethods.FullNameCache.Count, 1);
    }
}