using System;
using System.Threading;
namespace Clock
{
    public class Program
    {
         public static void Main()
        {
            Clock clock = new Clock();

            for(int i = 0; i <86; i++)
            {
                //Console.Clear();
                clock.Tick();
                Console.WriteLine(clock.CurrentTime());
                
                //Thread.Sleep(10);//delay of 10 milliseconds betn each tick
            }

            


        }
    }
}