namespace SinglyLinkedList.Backend;

public class SinglyLinkedList<T>
{
    private SingleNode<T>? _head;

    public SinglyLinkedList()
    {
        _head = null;
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new SingleNode<T>(data);
        newNode.Next = _head;
        _head = newNode;
    }

    public void InsertAtEnd(T data)
    {
        var newNode = new SingleNode<T>(data);
        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            var current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Remove(T data)
    {
        if (_head == null)
        {
            return;
        }
        if (_head.Data!.Equals(data))
        {
            _head = _head.Next;
            return;
        }
        var current = _head;
        while (current.Next != null && !current.Next.Data!.Equals(data))
        {
            current = current.Next;
        }
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void Clear()
    {
        _head = null;
    }

    public void PrintList()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}