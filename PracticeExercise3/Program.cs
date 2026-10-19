namespace PracticeExercise3;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("Connor");
        stack.Push("Jonathan");
        stack.Push("JD");

        Console.WriteLine( stack.Pop() );

    }
}

