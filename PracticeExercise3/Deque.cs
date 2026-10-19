namespace PracticeExercise3;

public class Deque<T> : IDeque<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    /// <summary>
    /// True if the deque contains no items; otherwise false.
    /// </summary>
    public bool IsEmpty => throw new NotImplementedException();

    /// <summary>
    /// The number of items currently in the deque.
    /// </summary>
    public int Count => throw new NotImplementedException();

    /// <summary>
    /// The item at the front of the deque. Does not remove the item.
    /// </summary>
    /// <exception cref="EmptyQueueException">Thrown if the deque is empty.</exception>
    public T Front => throw new NotImplementedException();

    /// <summary>
    /// The item at the back of the deque. Does not remove the item.
    /// </summary>
    /// <exception cref="EmptyQueueException">Thrown if the deque is empty.</exception>
    public T Back => throw new NotImplementedException();

    /// <summary>
    /// Adds an item to the back of the deque.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void AddBack(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds an item to the front of the deque.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void AddFront(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes and returns the item at the back of the deque.
    /// </summary>
    /// <returns>The item that was at the back.</returns>
    /// <exception cref="EmptyQueueException">Thrown if the deque is empty.</exception>
    public T RemoveBack()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes and returns the item at the front of the deque.
    /// </summary>
    /// <returns>The item that was at the front.</returns>
    /// <exception cref="EmptyQueueException">Thrown if the deque is empty.</exception>
    public T RemoveFront()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes all items from the deque. Clearing an empty deque does nothing.
    /// </summary>
    public void Clear()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the items from back to front, separated by arrows
    /// (e.g. "&lt;Back&gt; 3 → 2 → 1 &lt;Front&gt;").
    /// An empty deque returns "&lt;Back&gt;  &lt;Front&gt;".
    /// </summary>
    public override string ToString()
    {
        string result = "<Back> ";

        var currentNode = linkedList.Last;
        while (currentNode != null)
        {
            result += currentNode.Value;
            if (currentNode.Previous != null)
            {
                result += " → ";
            }
            currentNode = currentNode.Previous;
        }

        result += " <Front>";

        return result;
    }
}
