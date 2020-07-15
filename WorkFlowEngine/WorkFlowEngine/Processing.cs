using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{
    /// <summary class = "Processing">
    /// The execute method in this class shows that processing would be its main purpose when executed. 
    /// </summary>
    public class Processing : IActivity<Processing>
    {
        public Processing() { }

        public void Execute()
        {
            Console.WriteLine("Processing...");
        }
    }

}
