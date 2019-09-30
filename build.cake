#tool nuget:?package=MSBuild.SonarQube.Runner.Tool&version=4.6.0

var target = Argument("target", "Default");
var solutionDir = "src";

Task("Build")
    .Does(() =>
{
    var settings = new DotNetCoreBuildSettings
    {
        Configuration = "Release",
    };

    DotNetCoreBuild(solutionDir, settings);
});

Task("Test")
    .Does(() =>
{
    var settings = new DotNetCoreTestSettings
    {
        ArgumentCustomization = args => {
            return args.Append("/p:CollectCoverage=true")
                       .Append("/p:CoverletOutputFormat=opencover");
        }
    };

    DotNetCoreTest(solutionDir, settings);
});

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("Test")
	.Does(()=> { 
});

RunTarget(target);