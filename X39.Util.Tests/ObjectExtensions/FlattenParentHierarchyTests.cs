using System.Linq;
using NUnit.Framework;

namespace X39.Util.Tests.ObjectExtensions;

public class FlattenParentHierarchyTests
{
    private TestClass _testClass = null!;
    private int _testClassCount;
    private TestStruct _testStruct = null!;
    private int _testStructCount;

    private class TestStruct
    {
        public TestStruct(int i)
        {
            Index = i;
        }

        public int Index { get; }

        public TestStruct? Parent { get; init; }
    }
    private class TestClass
    {
        public TestClass(int i)
        {
            Index = i;
        }

        public int Index { get; }

        public TestClass? Parent { get; init; }
    }

    [SetUp]
    public void Setup()
    {
        var i = 0;
        _testClass = new TestClass(++i)
        {
            Parent = new TestClass(++i)
            {
                Parent = new TestClass(++i)
                {
                    Parent = new TestClass(++i)
                    {
                        Parent = new TestClass(++i)
                        {
                            Parent = new TestClass(++i)
                            {
                                Parent = new TestClass(++i)
                                {
                                    Parent = new TestClass(++i)
                                    {
                                        Parent = new TestClass(++i)
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
        _testClassCount = i;
        i = 0;
        _testStruct = new TestStruct(++i)
        {
            Parent = new TestStruct(++i)
            {
                Parent = new TestStruct(++i)
                {
                    Parent = new TestStruct(++i)
                    {
                        Parent = new TestStruct(++i)
                        {
                            Parent = new TestStruct(++i)
                            {
                                Parent = new TestStruct(++i)
                                {
                                    Parent = new TestStruct(++i)
                                    {
                                        Parent = new TestStruct(++i)
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
        _testStructCount = i;
    }
    
    [Test]
    public void ClassFlattenCountMatchesExpected()
    {
        var flattened = _testClass.FlattenParentHierarchy((q) => q.Parent);
        Assert.AreEqual(_testClassCount, flattened.Count());
    }
    
    [Test]
    public void ClassFlattenElementsMatchOrder()
    {
        var flattened = _testClass.FlattenParentHierarchy((q) => q.Parent);
        var i = 0;
        foreach (var testClass in flattened)
        {
            Assert.AreEqual(++i, testClass.Index);
        }
    }
    
    [Test]
    public void StructFlattenCountMatchesExpected()
    {
        var flattened = _testStruct.FlattenParentHierarchy((q) => q.Parent);
        Assert.AreEqual(_testStructCount, flattened.Count());
    }
    
    [Test]
    public void StructFlattenElementsMatchOrder()
    {
        var flattened = _testStruct.FlattenParentHierarchy((q) => q.Parent);
        var i = 0;
        foreach (var testStruct in flattened)
        {
            Assert.AreEqual(++i, testStruct.Index);
        }
    }
}