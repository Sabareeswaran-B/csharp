
namespace AbstractClasses
{
    abstract class Animal
    {
        public abstract void cats();
        public abstract void dogs();
    }

    class Cats : Animal
    {
        public override void cats()
        {
            Console.WriteLine("Cats meow!");
        }

        public override void dogs()
        {

        }
    }
    class Dogs : Animal
    {
        public override void cats()
        {
        }

        public override void dogs()
        {
            Console.WriteLine("Dogs Bark!");
        }
    }

    class ExcerciseFive
    {
        public void run()
        {
            Cats cat = new Cats();
            Dogs dog = new Dogs();
            cat.cats();
            dog.dogs();
        }
    }
}