namespace SinglyLinkedList.Backend;

public class SingleNode<T>
{
    public SingleNode(T data)
    {
        Data = data;
        Next = null;
    }

    public T Data { get; set; }

    public SingleNode<T>? Next { get; set; }
}