using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System;
using System.Diagnostics;
using WorkFlowEngine;
using Xunit;

namespace WorkFlowEngineTests
{
    public class WorkFlowEngineTest
    {
        [Fact]
        public void Video_Execute_Upload()
        {
            var sut = new Video();

            sut.Execute();

        }


        [Fact]
        public void CloudStorage_Execute_CallWebService()
        {
            var sut = new CloudStorage();
            sut.Execute();
        }


        [Fact]
        public void WebService_Execute_SendEmail()
        {
            var sut = new WebService();
            sut.Execute(); 
        }

        [Fact]
        public void Processing_Execute_AllActivityProcessed()
        {
            var sut = new Processing();
            sut.Execute();

        }

        [Fact]
        public void WorkFlow_Run_RunAllActivities()
        {
            var sut = new WorkFlow(new Video(), new CloudStorage(), new WebService(), new Processing());
            sut.Run();

        }

    }
}
