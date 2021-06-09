using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller(args);
            controller.Start();
        }
    }
}
