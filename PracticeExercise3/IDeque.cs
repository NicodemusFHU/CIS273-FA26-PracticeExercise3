namespace PracticeExercise3;

public interface IDeque<T>
{
	void AddFront(T item);
	void AddBack(T item);

	// Throws EmptyQueueException if the deque is empty
	T RemoveFront();
	// Throws EmptyQueueException if the deque is empty
	T RemoveBack();

	void Clear();

	bool IsEmpty { get; }
	int Count { get; }

	// Throws EmptyQueueException if the deque is empty
	T Front { get; }
	// Throws EmptyQueueException if the deque is empty
	T Back { get; }

}

