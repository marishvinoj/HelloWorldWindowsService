using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HelloWorldWindowsService
{
    public class HelloWorldService
    {
        int milliseconds = 2000;
        public void Start()
        {
            Console.WriteLine("Hello World Program Started");
            for (int i = 0;i<3; i++)
            {
                Thread.Sleep(milliseconds);
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("--------------------------");
            }
        }
        public void Stop()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Printing current time {DateTime.Now} and this service will stoped after 2 seconds");
            Thread.Sleep(milliseconds);
            Console.WriteLine("Hello World Program end");
            Console.WriteLine("--------------------------");
        }
    }
}
