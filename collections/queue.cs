namespace CollectionsEx
{
    class QueueExcercise
    {
        public void run()
        {
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count);

            
            foreach (var item in strQ)
                Console.Write(item + ",");

            Console.WriteLine("\nTotal elements: {0}", strQ.Count);
        }
    }
}
