
using System.Collections;

var CustomLinkedList = new CustomLinkedList<int>();


CustomLinkedList.AddToFront(1);
CustomLinkedList.AddToFront(2);
CustomLinkedList.AddToFront(3);
CustomLinkedList.AddToEnd(99);
CustomLinkedList.Clear();


foreach (var item in CustomLinkedList)
{
    Console.WriteLine(item);
}


Console.ReadKey();
public interface ILinkedList<T> : ICollection<T>
{
    void AddToFront(T item);
    void AddToEnd(T item);
}



public class CustomLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _node;
    private int _counter = 0;
    public int Count => _counter;

    public bool IsReadOnly => false;

    public void Add(T? item)
    {
        AddToEnd(item);
    }

    public void AddToEnd(T? item)
    {
        var NewNode = new Node<T>(item);
        if (_node is null)
        {
            _node = NewNode;
        }
        else
        {
            /* TAke The Refrance Not copy  */
            var LastNode = GetNode().Last();
            /* TAke The Refrance Not copy  */
            LastNode.Next = NewNode;
        }
        _counter++;


    }

    public void AddToFront(T item)
    {

        _node = new Node<T>(item)
        {
            Next = _node,
        };

        _counter++;
    }

    public void Clear()
    {
        //Node<T>? OtherNode = _node;

        //while (OtherNode is not null)
        //{
        //    Node<T>? Tempo = OtherNode;
        //    Tempo = null;
        //    OtherNode = OtherNode.Next;
        //};
        //_counter = 0;
        //_node = null;

        /* 2 */
        //foreach (var item in GetNode().ToList())
        //{
        //    item.Next = null;
        //}
        //_node = null;

    }

    public bool Contains(T item)
    {
        return GetNode().Any(Value => Value.Val is null ? false : Value.Val.Equals(item));
    }

    public void CopyTo(T?[] array, int arrayIndex)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }
        if (arrayIndex < 0 || arrayIndex >= array.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(arrayIndex));
        }
        if (array.Length < _counter + arrayIndex)
        {
            throw new ArgumentException("Array is not Long Enough ");
        }
        foreach (var item in GetNode())
        {
            if (item.Val is not null)
            {
                array[arrayIndex] = item.Val;
                arrayIndex++;
            }
        }

    }

    public bool Remove(T item)
    {
        Node<T>? NewNode = null;

        foreach (var node in GetNode())
        {
            if ((item is null && node is null) || (node.Val is not null && node.Val.Equals(item)))
            {
                if (NewNode is null)
                {
                    NewNode = node;

                }
                else
                {
                    NewNode.Next = node.Next;

                }
                _counter--;
                return true;
            }
            NewNode = node;

        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in GetNode())
        {
            if (item.Val is not null)
            {
                yield return item.Val;

            }

        }

    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private IEnumerable<Node<T>> GetNode()
    {
        var current = _node;
        while (current is not null)
        {
            yield return current;
            current = current.Next;

        }
        yield break;
    }

}

public class Node<T>
{
    public T? Val { get; set; }
    public Node<T>? Next { get; set; }
    public Node(T val)
    {
        Val = val;
    }

    public override string ToString()
    {
        return $"Value{Val};Next{Next} ";
    }

}