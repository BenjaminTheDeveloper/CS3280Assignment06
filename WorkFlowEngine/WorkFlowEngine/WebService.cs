using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{
    /// <summary class = "WebService">
    /// This is created as a mock web service and the execute method represents the real process with a simple text. 
    /// </summary>
    public class WebService : IActivity<WebService>
    {


        public WebService() { }

        public void Execute()
        {
            Console.WriteLine("Sending email to owner...");
        }


    }

}
