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
            else return _root.count;
        }
    }
    public int Sum
    {
        get
        {
            if(_root == null)
            {
                return 0;
            }
            else return _root.sum;
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
        else _root.insert(v);
    }
    public bool Find(int v)
    {
        if (_root == null)
        {
            return false;
        }
        else return _root.find(v);
    }
    public bool Duplicate
    {
        get
        {
            if (_root == null)
            {
                return false;
            }
            else return _root.duplicate;
        }
    }
    public int Depth
    {
        get
        {
            if(_root == null)
            {
                return 0;
            }
            else return _root.depth;
        }
    }
    public bool Balance
    {
        get
        {
            if (_root == null)
            {
                return true;
            }
            else return _root.balance;
        }
    }
    public override string ToString()
    {
        if (_root == null)
        {
            return "None";
        }
        else return _root.ToString();
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
    internal int count
    {
        get
        {
            if (_Left == null)
            {
                if (_Right == null)
                {
                    return 1;
                }
                else return _Right.count+1;
            }
            else
            {
                if(_Right == null)
                {
                    return _Left.count+1;
                }
                else return _Left.count+_Right.count+1;
            }
        }
    }
    internal int sum
    {
        get
        {
            if (_Left == null)
            {
                if (_Right == null)
                {
                    return _value;
                }
                else return _Right.sum+_value;
            }
            else
            {
                if(_Right == null)
                {
                    return _Left.sum+_value;
                }
                else return _Left.sum+_Right.sum+_value;
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
            else _Right.insert(v);
        }
        else
        {
            if (_Left == null)
            {
                _Left=new Node(v);
                return;
            }
            else _Left.insert(v);
        }
    }
    internal bool find(int v)
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
    internal bool duplicate
    {
        get
        {
            if (_Right != null)
            {
                if (_Right._value == _value)
                {
                    return true;
                }
                else
                {
                    return _Right.duplicate;
                }
            }
            if (_Left != null)
            {
                return _Left.duplicate;
            }
            return false;
        }
    }
    internal int depth
    {
        get
        {
            if (_Left == null)
            {
                if (_Right == null)
                {
                    return 1;
                }
                else return 1+_Right.depth;
            }
            else
            {
                if (_Right == null)
                {
                    return _Left.depth+1;
                }
                else return Math.Max(_Left.depth, _Right.depth)+1;
            }
        }
    }
    internal bool balance
    {
        get
        {
            if (_Left == null && _Right == null)
            {
                return true;
            }
            else if (_Left!=null&&_Right!=null)
            {
                if (_Left.balance && _Right.balance)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
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