using System;
using System.Collections.Generic;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WorkFlow Engine");

            //This workFlow is designed to execute all the activities throughout the program. 
            WorkFlow workFlow = new WorkFlow(new Video(), new CloudStorage(), new WebService(), new Processing());

            //This runs each activities Execute(); 
            workFlow.Run();

            Console.ReadKey();
        }
    }

}
