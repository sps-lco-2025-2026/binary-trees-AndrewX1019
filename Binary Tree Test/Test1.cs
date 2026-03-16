using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Binary_Tree_Library;

namespace Binary_Tree_Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Testcreate()
    {
        var b_t = new Binary_Tree(1);
        var B_T = new Binary_Tree();
    }
    [TestMethod]
    public void Testinsert()
    {
        var b_t = new Binary_Tree();
        b_t.Insert(2);
        b_t.Insert(0);
        b_t.Insert(1);
        b_t.Insert(3);
        b_t.Insert(4);
        Assert.AreEqual("0 1 2 3 4", b_t.ToString());
    }
    [TestMethod]
    public void Testcount()
    {
        var b_t = new Binary_Tree();
        b_t.Insert(3);
        b_t.Insert(4);
        b_t.Insert(2);
        Assert.AreEqual(3, b_t.Count);
    }
    [TestMethod]
    public void Testsum()
    {
        var b_t = new Binary_Tree();
        b_t.Insert(2);
        b_t.Insert(0);
        b_t.Insert(1);
        b_t.Insert(3);
        b_t.Insert(4);
        Assert.AreEqual(10, b_t.Sum);
    }
    [TestMethod]
    public void Testduplicate()
    {
        var b_t = new Binary_Tree();
        b_t.Insert(2);
        b_t.Insert(3);
        b_t.Insert(3);
        b_t.Insert(1);
        Assert.IsTrue(b_t.Duplicate);
        var B_T=new Binary_Tree();
        B_T.Insert(1);
        B_T.Insert(2);
        B_T.Insert(3);
        B_T.Insert(0);
        Assert.IsFalse(B_T.Duplicate);
    }
    [TestMethod]
    public void Testdepth()
    {
        var b_t=new Binary_Tree();
        b_t.Insert(2);
        b_t.Insert(0);
        b_t.Insert(1);
        b_t.Insert(3);
        b_t.Insert(4);
        Assert.AreEqual(3, b_t.Depth);
    }
    [TestMethod]
    public void Testbalance()
    {
        var b_t=new Binary_Tree();
        b_t.Insert(2);
        b_t.Insert(1);
        b_t.Insert(0);
        b_t.Insert(1);
        b_t.Insert(3);
        b_t.Insert(2);
        b_t.Insert(3);
        Assert.IsTrue(b_t.Balance);
    }
}
