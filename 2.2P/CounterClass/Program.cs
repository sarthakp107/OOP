namespace CounterTask;
//104817068
class Program
{

     public static void Main(string[] args)
    {
        
        //array of 3 counter objects
        Counter[] myCounters = new Counter[3];
        myCounters[0] =new Counter("Counter 1");
        myCounters[1] = new Counter("Counter 2");
        myCounters[2] = myCounters[0];

        for(int i =1;i<=9;i++)
        {
            myCounters[0].Increment();
        }

        for (int i = 1; i <= 14; i++)
        {
            myCounters[1].Increment(); //Increment() method in CounterClass
        }

        PrintCounters(myCounters);
        
        //reset for myCounter[2]
        myCounters[2].Reset();

        PrintCounters(myCounters);
        Console.ReadLine();
    }

    //PrintCounters method with counters as a parameter
    private static void  PrintCounters(Counter[] counters) //Counter as a data type
    {
        foreach(Counter c in counters)
        {
            Console.WriteLine("{0} is {1}" ,c.Name, c.Ticks);
        }

    }
}

