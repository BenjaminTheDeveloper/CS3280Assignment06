# CS3280Assignment06

      WorkFlow Engine
      Created to mock a workflow engine that runs many activities. 
      
# Activities

    Video
    CloudStorage
    WebService
    Processing
    
    These activites simulate how a workflow engine will run the activities. Each activity contains an Execute() method. That is provided by the interface IActivity.

# Program 

    This program takes a Workflow provided with a video, cloudStorage, webService and Processing object. 
    Then the work flow runs all activities as an example of how the program will be ran when fully coded. 
    
# Interface 
    
    IActivity Interface 
      void Execute(); Requires that each class that uses IActivity have an Execute method
