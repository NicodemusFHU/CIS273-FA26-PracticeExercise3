using PracticeExercise3;

namespace UnitTests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void TestStackPush()
    {
        var stack = new PracticeExercise3.Stack<int>();
        Assert.AreEqual("", stack.ToString());

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(5);
        stack.Push(8);

        Assert.AreEqual(5, stack.Count);
        Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());

    }

    [TestMethod]
    public void TestStackPop()
    {
        // judah

        var stack = new PracticeExercise3.Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(5);
        stack.Push(8);
        stack.Push(13);
        Assert.AreEqual("13\n8\n5\n3\n2\n1\n", stack.ToString());

        Assert.AreEqual(13, stack.Pop());
        Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());

        Assert.AreEqual(8, stack.Pop());
        Assert.AreEqual(5, stack.Pop());
        Assert.AreEqual(3, stack.Pop());
        Assert.AreEqual(2, stack.Pop());
        Assert.AreEqual(1, stack.Pop());
        Assert.AreEqual("", stack.ToString());

        stack = new PracticeExercise3.Stack<int>();

        stack.Push(5);
        Assert.AreEqual(5, stack.Pop());
        Assert.AreEqual(0, stack.Count);

        Assert.ThrowsExactly<EmptyStackException>(() => stack.Pop());
    }

    [TestMethod]
    public void TestStackPeek()
    {
        // lou
        var stack = new PracticeExercise3.Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(5);
        stack.Push(8);

        Assert.AreEqual(5, stack.Count);

        Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());
        stack.Pop();
        Assert.AreEqual(5, stack.Peek());
        Assert.AreEqual(4, stack.Count);
        Assert.AreEqual("5\n3\n2\n1\n", stack.ToString());

        stack.Pop();

        Assert.AreEqual(3, stack.Peek());
        Assert.AreEqual(3, stack.Count);

        Assert.AreEqual("3\n2\n1\n", stack.ToString());

        stack.Pop();
        stack.Pop();
        stack.Pop();

        Assert.AreEqual(0, stack.Count);

        Assert.ThrowsExactly<EmptyStackException>(() => stack.Peek());
    }

    [TestMethod]
    public void TestStackLength()
    {
        // danny

        var stack = new PracticeExercise3.Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Assert.AreEqual(5, stack.Count);

        var stack2 = new PracticeExercise3.Stack<int>();
        stack2.Push(5);
        stack2.Push(10);
        stack2.Push(15);
        stack2.Push(20);
        stack2.Push(25);
        stack2.Push(30);
        stack2.Push(35);

        Assert.AreEqual(7, stack2.Count);

        var stack3 = new PracticeExercise3.Stack<int>();
        stack3.Push(1);

        Assert.AreEqual(1, stack3.Count);
    }

    [TestMethod]
    public void TestStackIsEmpty()
    {
        // kelly

        var stack = new PracticeExercise3.Stack<int>();

        Assert.IsTrue(stack.IsEmpty);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(5);
        stack.Push(8);

        Assert.IsFalse(stack.IsEmpty);

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();

        Assert.IsTrue(stack.IsEmpty);
    }

    [TestMethod]
    public void TestStackInterleaved()
    {
        var stack = new PracticeExercise3.Stack<string>();

        stack.Push("a");
        stack.Push("b");
        Assert.AreEqual("b", stack.Pop());

        stack.Push("c");
        stack.Push("d");
        Assert.AreEqual("d", stack.Peek());
        Assert.AreEqual(3, stack.Count);
        Assert.AreEqual("d\nc\na\n", stack.ToString());

        Assert.AreEqual("d", stack.Pop());
        Assert.AreEqual("c", stack.Pop());
        Assert.AreEqual("a", stack.Pop());
        Assert.IsTrue(stack.IsEmpty);
    }

    [TestMethod]
    public void TestStackClear()
    {
        var stack = new PracticeExercise3.Stack<int>();

        // clearing an empty stack does nothing
        stack.Clear();
        Assert.IsTrue(stack.IsEmpty);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        stack.Clear();
        Assert.IsTrue(stack.IsEmpty);
        Assert.AreEqual(0, stack.Count);
        Assert.AreEqual("", stack.ToString());
        Assert.ThrowsExactly<EmptyStackException>(() => stack.Peek());
        Assert.ThrowsExactly<EmptyStackException>(() => stack.Pop());

        // the stack is still usable after clearing
        stack.Push(4);
        Assert.AreEqual(1, stack.Count);
        Assert.AreEqual(4, stack.Pop());
    }

    [TestMethod]
    public void TestQueueDequeue()
    {
        // lauren
        var queue = new PracticeExercise3.Queue<int>();

        for (int i = 1; i < 10; i++)
        {
            queue.Enqueue(i);
        }

        Assert.AreEqual(1, queue.Dequeue());
        Assert.AreEqual(2, queue.Dequeue());

        Assert.AreEqual(7, queue.Count);
        Assert.AreEqual("<Back> 9 → 8 → 7 → 6 → 5 → 4 → 3 <Front>", queue.ToString());

        Assert.AreEqual(3, queue.Dequeue());
        Assert.AreEqual(4, queue.Dequeue());
        Assert.AreEqual(5, queue.Count);
        Assert.AreEqual("<Back> 9 → 8 → 7 → 6 → 5 <Front>", queue.ToString());

        queue.Enqueue(10);

        Assert.AreEqual(5, queue.Dequeue());
        Assert.AreEqual(6, queue.Dequeue());
        Assert.AreEqual(7, queue.Dequeue());
        Assert.AreEqual(8, queue.Dequeue());
        Assert.AreEqual(9, queue.Dequeue());
        Assert.AreEqual(10, queue.Dequeue());
        Assert.AreEqual(0, queue.Count);
        Assert.AreEqual("<Back><Front>", queue.ToString().Replace(" ", ""));

        Assert.ThrowsExactly<EmptyQueueException>(() => queue.Dequeue());

        var queue1 = new PracticeExercise3.Queue<int>();
        Assert.ThrowsExactly<EmptyQueueException>(() => queue1.Dequeue());

    }

    [TestMethod]
    public void TestQueueEnqueue()
    {
        //
        var queue = new PracticeExercise3.Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Assert.AreEqual(5, queue.Count);
        Assert.AreEqual("<Back> 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());

        queue.Enqueue(6);
        queue.Enqueue(7);

        Assert.AreEqual(7, queue.Count);
        Assert.AreEqual("<Back> 7 → 6 → 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());

    }

    [TestMethod]
    public void TestQueueFirst()
    {
        // savannah

        var queue = new PracticeExercise3.Queue<int>();
        Assert.ThrowsExactly<EmptyQueueException>(() => queue.First);

        for (int i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
            Assert.AreEqual(0, queue.First);
        }

        Assert.AreEqual(10, queue.Count);

        for (int i = 0; i < 10; i++)
        {
            Assert.AreEqual(i, queue.First);
            queue.Dequeue();
        }

        Assert.ThrowsExactly<EmptyQueueException>(() => queue.First);
    }

    [TestMethod]
    public void TestQueueLast()
    {
        // zach

        var queue = new PracticeExercise3.Queue<int>();

        Assert.ThrowsExactly<EmptyQueueException>(() => queue.Last);

        for (int i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
            Assert.AreEqual(i, queue.Last);
        }

        for (int i = 0; i < 10; i++)
        {
            Assert.AreEqual(9, queue.Last);
            queue.Dequeue();
        }

        Assert.ThrowsExactly<EmptyQueueException>(() => queue.Last);
    }

    [TestMethod]
    public void TestQueueIsEmpty()
    {
        // kenan

        var queue = new PracticeExercise3.Queue<int>();

        Assert.IsTrue(queue.IsEmpty);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        Assert.IsFalse(queue.IsEmpty);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        Assert.IsTrue(queue.IsEmpty);

    }

    [TestMethod]
    public void TestQueueLength()
    {
        // john allen

        var queue = new PracticeExercise3.Queue<int>();
        Assert.AreEqual(0, queue.Count);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Assert.AreEqual(5, queue.Count);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        Assert.AreEqual(0, queue.Count);
    }

    [TestMethod]
    public void TestQueueInterleaved()
    {
        var queue = new PracticeExercise3.Queue<string>();

        queue.Enqueue("a");
        queue.Enqueue("b");
        Assert.AreEqual("a", queue.Dequeue());

        queue.Enqueue("c");
        Assert.AreEqual("b", queue.First);
        Assert.AreEqual("c", queue.Last);
        Assert.AreEqual("b", queue.Dequeue());

        // queue drained to a single item, then refilled
        queue.Enqueue("d");
        Assert.AreEqual("c", queue.First);
        Assert.AreEqual("d", queue.Last);
        Assert.AreEqual("<Back> d → c <Front>", queue.ToString());

        Assert.AreEqual("c", queue.Dequeue());
        Assert.AreEqual("d", queue.Dequeue());
        Assert.IsTrue(queue.IsEmpty);

        queue.Enqueue("e");
        Assert.AreEqual("e", queue.First);
        Assert.AreEqual("e", queue.Last);
        Assert.AreEqual("e", queue.Dequeue());
    }

    [TestMethod]
    public void TestQueueClear()
    {
        var queue = new PracticeExercise3.Queue<int>();

        // clearing an empty queue does nothing
        queue.Clear();
        Assert.IsTrue(queue.IsEmpty);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Clear();
        Assert.IsTrue(queue.IsEmpty);
        Assert.AreEqual(0, queue.Count);
        Assert.AreEqual("<Back><Front>", queue.ToString().Replace(" ", ""));
        Assert.ThrowsExactly<EmptyQueueException>(() => queue.First);
        Assert.ThrowsExactly<EmptyQueueException>(() => queue.Last);
        Assert.ThrowsExactly<EmptyQueueException>(() => queue.Dequeue());

        // the queue is still usable after clearing
        queue.Enqueue(4);
        queue.Enqueue(5);
        Assert.AreEqual(4, queue.First);
        Assert.AreEqual(5, queue.Last);
        Assert.AreEqual(4, queue.Dequeue());
    }

    [TestMethod]
    public void TestDequeAddFront()
    {
        // sean

        Deque<int> deque = new Deque<int>();

        deque.AddFront(1);
        Assert.AreEqual(1, deque.Front);

        deque.AddFront(2);
        Assert.AreEqual(2, deque.Front);

        deque.AddFront(3);
        Assert.AreEqual(3, deque.Front);

        deque.AddFront(4);
        Assert.AreEqual(4, deque.Front);

        deque.AddFront(5);
        Assert.AreEqual(5, deque.Front);

        Assert.AreEqual(5, deque.Count);
        Assert.AreEqual(1, deque.Back);

        Assert.AreEqual("<Back> 1 → 2 → 3 → 4 → 5 <Front>", deque.ToString());
    }

    [TestMethod]
    public void TestDequeAddBack()
    {
        // tristan
        Deque<int> deque = new Deque<int>();

        deque.AddBack(1);
        deque.AddBack(2);
        deque.AddBack(3);
        deque.AddBack(4);
        deque.AddBack(5);

        Assert.AreEqual(5, deque.Count);
        Assert.AreEqual(1, deque.Front);
        Assert.AreEqual(5, deque.Back);
        Assert.AreEqual("<Back> 5 → 4 → 3 → 2 → 1 <Front>", deque.ToString());

        deque.RemoveBack();
        deque.AddBack(6);
        Assert.AreEqual(5, deque.Count);
        Assert.AreEqual(1, deque.Front);
        Assert.AreEqual(6, deque.Back);
        Assert.AreEqual("<Back> 6 → 4 → 3 → 2 → 1 <Front>", deque.ToString());

    }

    [TestMethod]
    public void TestDequeRemoveFront()
    {
        // madison

        Deque<int> deque = new Deque<int>();

        for (int i = 0; i < 5; i++)
        {
            deque.AddBack(i);
        }

        Assert.AreEqual(5, deque.Count);
        Assert.AreEqual("<Back> 4 → 3 → 2 → 1 → 0 <Front>", deque.ToString());

        Assert.AreEqual(0, deque.RemoveFront());
        Assert.AreEqual("<Back> 4 → 3 → 2 → 1 <Front>", deque.ToString());

        deque.AddFront(-1);

        Assert.AreEqual("<Back> 4 → 3 → 2 → 1 → -1 <Front>", deque.ToString());
        Assert.AreEqual(-1, deque.RemoveFront());
        Assert.AreEqual("<Back> 4 → 3 → 2 → 1 <Front>", deque.ToString());

        Assert.AreEqual(1, deque.RemoveFront());
        Assert.AreEqual(2, deque.RemoveFront());
        Assert.AreEqual(3, deque.RemoveFront());
        Assert.AreEqual(4, deque.RemoveFront());

        Assert.ThrowsExactly<EmptyQueueException>(() => deque.RemoveFront());
    }

    [TestMethod]
    public void TestDequeRemoveBack()
    {
        // kenan
        Deque<int> deque = new Deque<int>();

        Assert.ThrowsExactly<EmptyQueueException>(() => deque.RemoveBack());

        deque.AddBack(1);
        deque.AddBack(2);
        deque.AddBack(3);
        deque.AddBack(4);
        deque.AddBack(5);

        Assert.AreEqual(5, deque.Count);
        Assert.AreEqual("<Back> 5 → 4 → 3 → 2 → 1 <Front>", deque.ToString());

        Assert.AreEqual(5, deque.RemoveBack());
        Assert.AreEqual(4, deque.Count);
        Assert.AreEqual("<Back> 4 → 3 → 2 → 1 <Front>", deque.ToString());

        Assert.AreEqual(4, deque.RemoveBack());
        Assert.AreEqual(3, deque.RemoveBack());
        Assert.AreEqual(2, deque.RemoveBack());
        Assert.AreEqual(1, deque.RemoveBack());

        Assert.ThrowsExactly<EmptyQueueException>(() => deque.RemoveBack());
    }


    [TestMethod]
    public void TestDequeIsEmpty()
    {
        // kenan
        Deque<int> deque = new Deque<int>();

        Assert.IsTrue(deque.IsEmpty);

        deque.AddBack(1);
        deque.AddBack(2);
        deque.AddBack(3);
        deque.AddBack(4);
        deque.AddBack(5);

        Assert.IsFalse(deque.IsEmpty);

        deque.RemoveBack();
        deque.RemoveBack();
        deque.RemoveBack();
        deque.RemoveBack();
        deque.RemoveBack();

        Assert.IsTrue(deque.IsEmpty);
    }

    [TestMethod]
    public void TestDequeLength()
    {
        // kenan
        Deque<int> deque = new Deque<int>();

        Assert.AreEqual(0, deque.Count);

        deque.AddBack(1);
        deque.AddBack(2);
        deque.AddBack(3);
        deque.AddBack(4);
        deque.AddBack(5);

        Assert.AreEqual(5, deque.Count);

        deque.RemoveBack();
        deque.RemoveFront();

        Assert.AreEqual(3, deque.Count);

        deque.RemoveBack();
        deque.RemoveBack();
        deque.RemoveBack();

        Assert.AreEqual(0, deque.Count);

    }

    [TestMethod]
    public void TestDequeFront()
    {
        // tim

        Deque<int> deque = new Deque<int>();

        Assert.ThrowsExactly<EmptyQueueException>(() => deque.Front);

        deque.AddFront(1);
        deque.AddFront(2);
        deque.AddFront(3);
        deque.AddFront(4);
        deque.AddFront(5);

        Assert.AreEqual(5, deque.Front);

        deque.RemoveFront();

        Assert.AreEqual(4, deque.Front);

        deque.RemoveFront();
        deque.RemoveFront();
        deque.RemoveFront();

        Assert.AreEqual(1, deque.Front);

        deque.RemoveFront();

        Assert.ThrowsExactly<EmptyQueueException>(() => deque.Front);
    }

    [TestMethod]
    public void TestDequeBack()
    {
        // bryce

        Deque<int> myDeque = new Deque<int>();

        Assert.ThrowsExactly<EmptyQueueException>(() => myDeque.Back);

        for (int i = 0; i < 5; i++)
        {
            myDeque.AddBack(i);
        }

        Assert.AreEqual(4, myDeque.Back);

        myDeque.AddBack(5);
        myDeque.AddFront(6);

        Assert.AreEqual(5, myDeque.Back);

        myDeque.RemoveBack();
        myDeque.RemoveBack();

        Assert.AreEqual(3, myDeque.Back);

        myDeque.RemoveFront();

        Assert.AreEqual(3, myDeque.Back);

        myDeque.RemoveBack();
        myDeque.RemoveBack();
        myDeque.RemoveBack();
        myDeque.RemoveBack();

        Assert.ThrowsExactly<EmptyQueueException>(() => myDeque.Back);
    }

    [TestMethod]
    public void TestDequeSingleElement()
    {
        Deque<int> deque = new Deque<int>();

        // one item is both the front and the back
        deque.AddFront(7);
        Assert.AreEqual(7, deque.Front);
        Assert.AreEqual(7, deque.Back);
        Assert.AreEqual(7, deque.RemoveBack());
        Assert.IsTrue(deque.IsEmpty);
        Assert.AreEqual("<Back><Front>", deque.ToString().Replace(" ", ""));

        deque.AddBack(8);
        Assert.AreEqual(8, deque.Front);
        Assert.AreEqual(8, deque.Back);
        Assert.AreEqual(8, deque.RemoveFront());
        Assert.IsTrue(deque.IsEmpty);

        Assert.ThrowsExactly<EmptyQueueException>(() => deque.Front);
        Assert.ThrowsExactly<EmptyQueueException>(() => deque.Back);
    }

    [TestMethod]
    public void TestDequeCrossEnds()
    {
        Deque<string> deque = new Deque<string>();

        // AddFront + RemoveBack behaves like a queue
        deque.AddFront("a");
        deque.AddFront("b");
        deque.AddFront("c");
        Assert.AreEqual("<Back> a → b → c <Front>", deque.ToString());
        Assert.AreEqual("a", deque.RemoveBack());
        Assert.AreEqual("b", deque.RemoveBack());
        Assert.AreEqual("c", deque.RemoveBack());
        Assert.IsTrue(deque.IsEmpty);

        // AddBack + RemoveFront also behaves like a queue
        deque.AddBack("x");
        deque.AddBack("y");
        deque.AddBack("z");
        Assert.AreEqual("<Back> z → y → x <Front>", deque.ToString());
        Assert.AreEqual("x", deque.RemoveFront());
        Assert.AreEqual("y", deque.RemoveFront());
        Assert.AreEqual("z", deque.RemoveFront());
        Assert.IsTrue(deque.IsEmpty);
    }

    [TestMethod]
    public void TestDequeClear()
    {
        Deque<int> deque = new Deque<int>();

        // clearing an empty deque does nothing
        deque.Clear();
        Assert.IsTrue(deque.IsEmpty);

        deque.AddFront(1);
        deque.AddBack(2);
        deque.AddFront(3);

        deque.Clear();
        Assert.IsTrue(deque.IsEmpty);
        Assert.AreEqual(0, deque.Count);
        Assert.AreEqual("<Back><Front>", deque.ToString().Replace(" ", ""));
        Assert.ThrowsExactly<EmptyQueueException>(() => deque.Front);
        Assert.ThrowsExactly<EmptyQueueException>(() => deque.Back);
        Assert.ThrowsExactly<EmptyQueueException>(() => deque.RemoveFront());
        Assert.ThrowsExactly<EmptyQueueException>(() => deque.RemoveBack());

        // the deque is still usable after clearing
        deque.AddBack(4);
        deque.AddFront(5);
        Assert.AreEqual(5, deque.Front);
        Assert.AreEqual(4, deque.Back);
        Assert.AreEqual(2, deque.Count);
    }
}
