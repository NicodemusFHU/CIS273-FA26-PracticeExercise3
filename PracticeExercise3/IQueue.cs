namespace PracticeExercise3;

public interface IQueue<T>
{
	void Enqueue(T item);
	T Dequeue();
	void Clear();

	T First { get; }
	T Last { get; }

	int Count { get; }
	bool IsEmpty { get; }
}

