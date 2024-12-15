namespace Assignment_6._2._1
{
    internal class Program
    {
        static void Main()
        {
            Stack stack = new Stack(5); // Initialize stack with a size of 5

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine("Popped item: " + stack.Pop());
            Console.WriteLine("Popped item: " + stack.Pop());

            stack.Push(60);

            Console.WriteLine("Popped item: " + stack.Pop());
        }
    }

    class Stack
    {
        private int[] elements;
        private int top;
        private int max;

        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            elements[++top] = item;
            Console.WriteLine($"Pushed item: {item}");
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1; // Returning -1 to indicate underflow
            }

            return elements[top--];
        }
    }
}