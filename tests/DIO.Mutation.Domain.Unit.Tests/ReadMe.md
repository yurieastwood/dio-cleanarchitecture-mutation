## Get started 

The solution DIO.Mutation uses NUnit framework to run the unit test.
The Stryker .NET tool run the unit tests that you have in your project, so, we need to install one adapter in our test project specified in the next section.

## Technologies used

* Stryker.NET: https://stryker-mutator.io/docs/stryker-net/Getting-started/

## Version requirements
 
* NUnit3Adapter version 4.0.0

## Command to run project

Via command prompt we should navigate to your test folder, more specifically where is placed the .csproj file

```bash
dotnet stryker --solution-path "../../DIO.Mutation.sln"
```

> Remember to uncomment the test that you want to validate before really runs the command.

## Results

After run the command the Stryker tool will generate a folder inside your project test named as .\StrykerOutput.
This folder will contain the log related to the execution and also an html page regarding to the report.
The report can be opened in any browser and will show with a user friendly interface where we can analyze the problems in our unit tests.