using System;
using Topshelf;

namespace HelloWorldWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Configure();
        }

        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<HelloWorldService>(service =>
                {
                    service.ConstructUsing(s => new HelloWorldService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });

                //Setup Account that window service use to run.  
                configure.RunAsLocalSystem();
                //This is the Service Name which will be created in your services.msc
                configure.SetServiceName("HelloWorldWindowsServiceWithTopshelf");
                //This is the Display Name which will be created in your services.msc
                configure.SetDisplayName("Windows Service With Topshelf");
                configure.SetDescription("Hello World Windows Service with Topshelf");
            });
        }
    }
}
