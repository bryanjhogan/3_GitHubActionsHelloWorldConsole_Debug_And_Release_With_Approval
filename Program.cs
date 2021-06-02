using System;

namespace GitHubActionsHelloWorldConsole_Debug_And_Release_With_Approval
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
