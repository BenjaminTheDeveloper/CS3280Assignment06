using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{   
    /// <summary class = "Video">
    /// The execute method found in this class is made to represent what the execute would be for in a real program.
    /// </summary>

    public class Video : IActivity<Video>
    {
        public Video() { }

        public void Execute()
        {
            Console.WriteLine("Uploading Video...");
        }
    }
}
