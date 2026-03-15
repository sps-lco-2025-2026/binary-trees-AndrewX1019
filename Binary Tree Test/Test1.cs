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
}
