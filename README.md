INTRODUCTION
    This application is a simple todo list created using ASP.NET CORE MVC. 

REQUIRED FILES
    * AspNetCoreTodo - The main application file containing subfiles required to run the application.
    * AspNetCoreTodo.IntegrationTests - A simple integration test file.
    * AspNetCoreTodo.UnitTests - A simple unit test file.
    * nginx - Deployment file for deployment using nginx.
    * .deployment - Deployment file for deployment using Microsoft Azure.
    * Dockerfile - Deployment file for deployment using Docker.
    * README.md - This file.

BUILDING AND RUNNING APPLICATION

    This file can be cloned via ssh or http link from github. It can be directly downloaded as well.

    From the directory contiaing the main application file (AspNetCoreTodo), build the application using:
        > dotnet build
    From the directory containing the main application, run the application using:
        > dotnet run
    If no error exists, the application is accessible at https://localhost:5001.
    
    NOTE: This application requires a user to login to be able to create their todo list.

BUILDING AND RUNNING TESTS
    There are two tests unit and integration available for adding more.
    From the directory containing the test files, run the test using:
        > dotnet test
    
    
    
