using System;
using Serilog;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Information("No one listens to me!");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.LiterateConsole()
                .CreateLogger();

            var fiets = new Fiets();

            Log.Information("How about now? {@Fiets}", fiets);
            Console.ReadKey();
        }
    }

    public class Fiets
    {
        public bool Bel { get; } = true;
    }
}
