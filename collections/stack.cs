namespace CollectionsEx
{
    class StackExcersice
    {
        public void run()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ",");

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek());
                Console.WriteLine(myStack.Peek());
            }

            Console.Write("Number of elements in Stack: {0}", myStack.Count);
        }
    }
}
