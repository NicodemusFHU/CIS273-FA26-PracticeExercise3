namespace PracticeExercise3;

public class EmptyQueueException : Exception
{
    public EmptyQueueException()
    {
    }

    public EmptyQueueException(string? message) : base(message)
    {
    }

    public EmptyQueueException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
