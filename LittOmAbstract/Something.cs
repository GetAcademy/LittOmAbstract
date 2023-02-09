namespace LittOmAbstract
{
    internal abstract class Something
    {
        protected Something()
        {
        }

        // abstract => må overrides
        public abstract void DoA();

        // virtual => kan overrides
        public virtual void DoB()
        {
            Console.WriteLine("B");
        }

        public void DoZ()
        {
            Console.WriteLine("Z");
        }
    }
}
