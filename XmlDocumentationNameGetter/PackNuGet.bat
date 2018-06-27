cd /D "%~dp0"
msbuild XmlDocumentationNameGetter.csproj /t:rebuild /verbosity:quiet /p:Configuration=Release
nuget pack XmlDocumentationNameGetter.csproj -OutputDirectory ..\..\..\LocalNuGet -Prop Configuration=Release