using System;
using System.Collections.Generic;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WorkFlow Engine");

            WorkFlow workFlow = new WorkFlow(new Video(), new CloudStorage(), new WebService(), new Processing());

            workFlow.Run();




            Console.ReadKey();
        }
    }




        interface IActivity<T>
        {
        public void Execute(); 
        }




    public class WorkFlow
    {
        Video video;
        CloudStorage cloudStorage;
        WebService webService;
        Processing processing; 

        public WorkFlow(Video video, CloudStorage cloudStorage, WebService webService, Processing processing) {
            this.video = video;
            this.cloudStorage = cloudStorage;
            this.webService = webService;
            this.processing = processing;
        
        
        
        }

        public void Run()
        {
            video.Execute();
            cloudStorage.Execute();
            webService.Execute();
            processing.Execute();
        }
    }
    public class Video: IActivity<Video>
    {
        public Video() { }

        public void Execute()
        {
            Console.WriteLine("Uploading Video..."); 
        }
    }
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

    public class WebService : IActivity<WebService>
    {





        public WebService() { }

        public void Execute()
        {
            Console.WriteLine("Sending email to owner.");
        }

    
    }


    public class Processing : IActivity<Processing>
    {
        public Processing() { }

        public void Execute()
        {
            Console.WriteLine("Processing...");
        }
    }

}
