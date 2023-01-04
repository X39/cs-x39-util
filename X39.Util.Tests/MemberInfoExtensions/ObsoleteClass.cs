using System;

namespace X39.Util.Tests.MemberInfoExtensions;

[Obsolete]
public class ObsoleteClass
{
    public bool Field;
    public bool Property { get; set; }
    public bool Method() => throw new InvalidOperationException();
    public class Nested {}
}

public class NonObsoleteClassWithAllMembersObsolete
{
    [Obsolete]
    public bool Field;
    [Obsolete]
    public bool Property { get; set; }
    [Obsolete]
    public bool Method() => throw new InvalidOperationException();
    [Obsolete]
    public class Nested {}
}

public class NonObsoleteClassWithAllMembersNotObsolete
{
    public bool Field;
    public bool Property { get; set; }
    public bool Method() => throw new InvalidOperationException();
    public class Nested {}
}