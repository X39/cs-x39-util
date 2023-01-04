using System.Reflection;
using NUnit.Framework;
using X39.Util.Tests.MemberInfoExtensions;
#pragma warning disable CS0612

namespace X39.Util.Tests;

public class IsObsoleteTests
{
    [Test]
    public void ObsoleteClassIsAllObsolete()
    {
        Assert.IsTrue(typeof(ObsoleteClass).IsObsolete());
        Assert.IsTrue(typeof(ObsoleteClass.Nested).IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<ObsoleteClass>(c => c.Field).IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<ObsoleteClass>(c => c.Property).IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<ObsoleteClass, PropertyInfo>(c => c.Property).GetMethod!.IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<ObsoleteClass, PropertyInfo>(c => c.Property).SetMethod!.IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<ObsoleteClass>(c => c.Method()).IsObsolete());
    }
    [Test]
    public void NonObsoleteClassIsNeverObsolete()
    {
        Assert.IsFalse(typeof(NonObsoleteClassWithAllMembersNotObsolete).IsObsolete());
        Assert.IsFalse(typeof(NonObsoleteClassWithAllMembersNotObsolete.Nested).IsObsolete());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersNotObsolete>(c => c.Field).IsObsolete());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersNotObsolete>(c => c.Property).IsObsolete());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersNotObsolete, PropertyInfo>(c => c.Property).GetMethod!.IsObsolete());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersNotObsolete, PropertyInfo>(c => c.Property).SetMethod!.IsObsolete());
        Assert.IsFalse(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersNotObsolete>(c => c.Method()).IsObsolete());
    }
    [Test]
    public void NonObsoleteClassWithAllMembersObsoleteIsAlwaysObsoleteForMembers()
    {
        Assert.IsFalse(typeof(NonObsoleteClassWithAllMembersObsolete).IsObsolete());
        Assert.IsTrue(typeof(NonObsoleteClassWithAllMembersObsolete.Nested).IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersObsolete>(c => c.Field).IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersObsolete>(c => c.Property).IsObsolete());
        // Assert.IsTrue(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersObsolete, PropertyInfo>(c => c.Property).GetMethod!.IsObsolete());
        // Assert.IsTrue(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersObsolete, PropertyInfo>(c => c.Property).SetMethod!.IsObsolete());
        Assert.IsTrue(TestHelpers.GetMemberInfo<NonObsoleteClassWithAllMembersObsolete>(c => c.Method()).IsObsolete());
    }
}