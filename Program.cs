using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiple Roblox Instances";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Before running Roblox or it will not work! You must use seperate accounts.\nIf you close this window, all Roblox instances will close except for one.\n\n");
            
            new Mutex(true, "ROBLOX_singletonMutex");
            Console.Write("Multiple Roblox Instances is now running!\n");
            Console.ReadLine();

        }
    }
}
