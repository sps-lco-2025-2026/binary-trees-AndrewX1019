using System.IO.Compression;

namespace Binary_Tree_Library;

public class Binary_Tree
{
    Node _root;
    public int Count
    {
        get
        {
            if (_root == null)
            {
                return 0;
            }
            else
            {
                return _root.Count;
            }
        }
    }
    public Binary_Tree()
    {
        _root=null;
    }
    public Binary_Tree(int v)
    {
        _root=new Node(v);
    }
    public void Insert(int v)
    {
        if (_root == null)
        {
            _root=new Node(v);
        }
        else
        {
            _root.insert(v);
        }
    }
    public bool Find(int v)
    {
        if (_root == null)
        {
            return false;
        }
        else
        {
            return _root.find(v);
        }
    }
    public override string ToString()
    {
        if (_root == null)
        {
            return "None";
        }
        else
        {
            return _root.ToString();
        }
    }
}

public class Node
{
    int _value;
    Node _Left;
    Node _Right;
    bool Exsistence;
    internal Node(int v)
    {
        _value=v;
    }
    internal int Count
    {
        get
        {
            if (_Left == null)
            {
                if (_Right == null)
                {
                    return 1;
                }
                else return _Right.Count+1;
            }
            else
            {
                if(_Right == null)
                {
                    return _Left.Count+1;
                }
                return _Left.Count+_Right.Count+1;
            }
        }
    }
    internal void insert(int v)
    {
        if (v >= _value)
        {
            if (_Right == null)
            {
                _Right=new Node(v);
                return;
            }
            _Right.insert(v);
        }
        else
        {
            if (_Left == null)
            {
                _Left=new Node(v);
                return;
            }
            _Left.insert(v);
        }
    }
    public bool find(int v)
    {
        if (_value == v)
        {
            return true;
        }
        if (v > _value&&_Right!=null)
        {
            return _Right.find(v);
        }
        if (v < _value && _Left != null)
        {
            return _Left.find(v);
        }
        return false;
    }
    public override string ToString()
    {
        if (_Left == null)
        {
            if (_Right == null)
            {
                return Convert.ToString(_value);
            }
            else
            {
                return Convert.ToString(_value)+" "+_Right.ToString();
            }
        }
        else
        {
            if (_Right == null)
            {
                return _Left.ToString()+" "+Convert.ToString(_value);
            }
            else
            {
                return _Left.ToString()+" "+Convert.ToString(_value)+" "+_Right.ToString();
            }
        }
    }
}