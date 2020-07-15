using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{
    /// <summary class = "CloudStorage">
    /// This is a mock Cloud Storage and the Execute Method shows what the cloud storage would do when executed. 
    /// </summary>

    public class CloudStorage : IActivity<CloudStorage>
    {


        public CloudStorage()
        {

        }
        public void Execute()
        {
            Console.WriteLine("Calling Web Service");
        }
    }

}
