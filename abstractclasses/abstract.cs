namespace AbstractClasses
{
    abstract class Sample
    {
        public Sample()
        {
            Console.WriteLine("This is a Constructor");
        }

        public void b_method()
        {
            Console.WriteLine("This is a normal method");
        }

        public abstract void a_method();
    }

    class SubClass : Sample
    {
        public override void a_method()
        {
            Console.WriteLine("This is a absract method");
        }
    }

    class ExcerciseEight
    {
        public void run()
        {
            SubClass obj = new SubClass();
            obj.a_method();
            obj.b_method();
        }
    }
}