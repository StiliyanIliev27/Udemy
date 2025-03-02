namespace Stack_Using_Array
{
    public class StackArray<T>
    {
        T[] data;
        int top;

        public StackArray(int n)
        {
            data = new T[n];
            top = 0;
        }

        public int Length() => data.Length;
        private bool IsEmpty()
        {
            return top == 0;
        }

        private bool IsFull()
        {
            return top == data.Length;
        }

        public void Push(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("The stack is full!");
                return;
            }

            data[top] = element;
            top++;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty!");
                return default!;
            }

            T element = data[top -1];
            top--;

            return element;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty!");
                return default!;
            }

            return data[top - 1];
        }
        public void Display()
        {
            for(int i = 0; i < top; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
