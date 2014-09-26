#HarSharp

A small and easy-to-use library to parse HTTP Archive (HAR) format to .NET objects.

--------

##Introduction
The HTTP Archive (HAR) format as defined in the [W3C Specification](https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html) is an archival format for HTTP transactions that can be used by a web browser to export detailed performance data about web pages it loads.

So, every modern browser nowadays can export HAR with a lot of information about the user navegation. Chrome, for example, can export HAR from Developer Tools, Network tab, right mouse click and "Copy all as HAR".

What I can do with HAR data?
Well, there a lot of things I can imagine right now, like:
- Web performance tests runners
- Performance analyzers
- Navigation visualizers

##Setup

####NuGet
PM> Install-Package HarSharp


--------

##Usage
###Deserialize from string
```csharp
var har = HarConvert.Deserialize(harContent);
```

###Deserialize from file
```csharp
var har = HarConvert.DeserializeFromFile(fileName);
```

###Listing pages load time
```csharp
var har = HarConvert.Deserialize(harContent);

foreach(var page in har.Log.Pages)
{
	Console.WriteLine("Page: {0} loaded in {1} milliseconds", page.Title, page.PageTimings.OnLoad);
}

##Code philosophy
The idea of HarSharp is simplify and promote the use of HAR in .NET codes and keep closest possible to [W3C specification](https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html) , for this reason the below rules were followed during the library development:
- Keep the entities and properties names equals to the one defined in the [specification](https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html), but follow the C# naming guidelines, so, "pages" became "Pages".
- Keep the properties types closest to the spec, but change when there is a better type on .NET side.
	- string (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD): System.DateTime (UTC).
	- string (url): System.Uri.
- Full documentation using citations from W3C specification.
- StyleCop validation.
- FxCop Validation.
- 100% unit test coverage

##FAQ

####Having troubles? 
 - Ask on [Stack Overflow](http://stackoverflow.com/search?q=HarSharp)

##Roadmap

  - Serialize HAR entities back to HAR file.
 
--------

##How to improve it?
- Create a fork of [HarSharp](https://github.com/giacomelli/HarSharp/fork). 
- Did you change it? [Submit a pull request](https://github.com/giacomelli/HarSharp/pull/new/master).


##License

Licensed under the The MIT License (MIT).
In others words, you can use this library for developement any kind of software: open source, commercial, proprietary and alien.


##Change Log
 - 1.0.0 First version.
