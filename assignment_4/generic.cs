
public class Node<T> where T:IComparable<T>//此处实现了IComparable接口
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }
    public Node(T t)
    {
        Data = t;
        Next = null;
        
    }
    //定义一个函数用于比较泛型节点大小
    public bool Compare(Node<T> node)
    {

        if (Data.GetType() != node.Data.GetType()) throw new ImcomparableException("The elements are not comparable!");
        if (Data.CompareTo(node.Data) < 0)
            {
                return true;
            }
            else return false;
        }
        
    
}
//异常定义
public class ImcomparableException : Exception
{
    public ImcomparableException(string message): base(message)
    {
        Console.WriteLine(message);
    }
} 
public class EmptyLinkListException : Exception
{
    public EmptyLinkListException(string message) : base(message) { 
        Console.WriteLine(message);
    }
}

//链表类
public class LinkList<T> where T:IComparable<T>
{
    private Node<T> head;
    private Node<T> tail;
    
    public LinkList()
    {
        head = tail = null;
    }
    public Node<T> Insert(T t)
    {
        Node<T> n = new Node<T>(t);

        n.Next = head.Next;
        head.Next = n;
        return head;
    }
    //输出所有节点
    public void Print()
    {
        Node<T> tmp = head;
        int inx = 1;
        while(tmp != null)
        {
            Console.WriteLine("the element{0} is {1}",inx, tmp.Data);
            inx++;
        }
    }
    //求最大的节点
    public Node<T> Max() 
    {
        Node<T> tmp = head.Next;
        if(tmp == null)
        {
            Exception e = new EmptyLinkListException("The linklist is empty!");
            throw e;
        }
        Node<T> max_node = tmp;
        while (tmp != null)
        {
            
            if (max_node.Compare(tmp))
            {
                max_node = tmp;
                tmp = tmp.Next;
            }
            
        }
        return max_node;
    }
}
