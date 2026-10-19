namespace PracticeExercise3;

public interface IStack<T>
{
	void Push(T item);

	T Pop();

	T Peek();

	void Clear();

	bool IsEmpty { get; }

	int Count { get; }

}


