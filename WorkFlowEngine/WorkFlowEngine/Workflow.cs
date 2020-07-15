using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{
    public class WorkFlow
    {
        Video video;
        CloudStorage cloudStorage;
        WebService webService;
        Processing processing;

        public WorkFlow(Video video, CloudStorage cloudStorage, WebService webService, Processing processing)
        {

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
}
