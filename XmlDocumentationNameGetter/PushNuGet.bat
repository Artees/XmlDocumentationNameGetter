cd /D "%~dp0"
cd ..\..\..\LocalNuGet
nuget push XmlDocumentationNameGetter.1.0.4.nupkg -Source https://api.nuget.org/v3/index.json