using System;

namespace GitHubActionsHelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
                Console.WriteLine("Hello World! From debug build.");
            #endif
            #if RELEASE       
                Console.WriteLine("Hello World! From release build.");
            #endif
        }
    }
}
