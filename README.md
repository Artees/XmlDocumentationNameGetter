# XmlDocumentationNameGetter

Allows to get the name of a type or a member that corresponds to the XML
documentation convention.

## Usage
Use the
`Artees.Tools.XmlDocumentationNameGetter.XmlDocumentationNameGetterExtensions.GetXmlDocsName`
extension methods to get the name.
```
var xmlName = typeof(object).GetXmlDocsName();
Console.WriteLine(xmlName);
```
The output would be:
```
T:System.Object
```
