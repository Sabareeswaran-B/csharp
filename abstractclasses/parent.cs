using System;

namespace AbstractClasses
{
    abstract class Parent
    {
        public abstract void message();
    }

    class SubclassOne : Parent
    {
        public override void message()
        {
            Console.WriteLine("This is the first Subclass");
        }
    }

    class SubclassTwo : Parent
    {
        public override void message()
        {
            Console.WriteLine("This is the second Subclass");
        }
    }

    class ExcerciseTwo
    {
        public void run()
        {
            SubclassOne one = new SubclassOne();
            SubclassTwo two = new SubclassTwo();
            one.message();
            two.message();
        }
    }
}
