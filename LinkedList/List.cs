namespace List;

public class List<T>
{
    private Node<T>? head;
    public static List<T> Empty()
    {
        return new List<T>();
    }
    public void Add(T value)
    {
        var newNode = new Node<T>(value);
        newNode.next = head;
        head = newNode;
    }
    public bool Contains(T value)
    {
        Node<T>? node = head;
        EqualityComparer<T> c = EqualityComparer<T>.Default;
        if (node != null)
        {
            if (value != null)
            {
                do
                {
                    if (c.Equals(node!.item, value))
                    {
                        return true;
                    }
                    node = node.next;
                } while (node != head);
            }
            else
            {
                do
                {
                    if (node!.item == null)
                    {
                        return true;
                    }
                    node = node.next;
                } while (node != head);
            }
        }
        return false;
    }
}

public sealed class Node<T>
{
    internal T item;
    internal Node<T>? next;
    public Node(T value)
    {
        item = value;
    }
}


