namespace PracticeExercise3;

public class Queue<T> : IQueue<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    /// <summary>
    /// The item at the front of the queue (the next item to be dequeued).
    /// Does not remove the item.
    /// </summary>
    /// <exception cref="EmptyQueueException">Thrown if the queue is empty.</exception>
    public T First => throw new NotImplementedException();

    /// <summary>
    /// The item at the back of the queue (the most recently enqueued item).
    /// Does not remove the item.
    /// </summary>
    /// <exception cref="EmptyQueueException">Thrown if the queue is empty.</exception>
    public T Last => throw new NotImplementedException();

    /// <summary>
    /// The number of items currently in the queue.
    /// </summary>
    public int Count => throw new NotImplementedException();

    /// <summary>
    /// True if the queue contains no items; otherwise false.
    /// </summary>
    public bool IsEmpty => throw new NotImplementedException();

    /// <summary>
    /// Removes and returns the item at the front of the queue.
    /// </summary>
    /// <returns>The item that has been in the queue the longest.</returns>
    /// <exception cref="EmptyQueueException">Thrown if the queue is empty.</exception>
    public T Dequeue()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds an item to the back of the queue.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void Enqueue(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes all items from the queue. Clearing an empty queue does nothing.
    /// </summary>
    public void Clear()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the items from back to front, separated by arrows
    /// (e.g. "&lt;Back&gt; 3 → 2 → 1 &lt;Front&gt;").
    /// An empty queue returns "&lt;Back&gt;  &lt;Front&gt;".
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
