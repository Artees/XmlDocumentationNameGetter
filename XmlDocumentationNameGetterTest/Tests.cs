using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Artees.Tools.XmlDocumentationNameGetter;
using NUnit.Framework;

namespace XmlDocumentationNameGetterTest
{
    [TestFixture]
    public class Tests
    {
        private readonly Type[] _assemblyTypes;
        private readonly List<string> _xmlMemberNames;

        public Tests()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                               "\\..\\..\\..\\XmlDocumentationNameGetterTestAssembly\\bin\\Debug" +
                               "\\XmlDocumentationNameGetterTestAssembly.dll";
            var xmlPath = assemblyPath.Replace(".dll", ".xml");
            var assembly = Assembly.LoadFile(assemblyPath);
            var xml = new XmlDocument();
            xml.Load(xmlPath);
            _assemblyTypes = assembly.GetTypes();
            var xmlMembers = xml.GetElementsByTagName("member");
            _xmlMemberNames = new List<string>();
            for (var i = 0; i < xmlMembers.Count; i++)
            {
                var xmlMember = xmlMembers.Item(i);
                _xmlMemberNames.Add(xmlMember?.Attributes?["name"].Value);
            }

            Assert.AreEqual(_xmlMemberNames.Count, xmlMembers.Count);
        }

        [Test]
        public void TestTypes()
        {
            foreach (var type in _assemblyTypes)
            {
                var xmlTypeName = type.GetXmlDocsName();
                AssertContains(_xmlMemberNames, xmlTypeName);
            }
        }

        [Test]
        public void TestMembers()
        {
            var excludePrefixes = new List<string> {"get_", "set_", "add_", "remove_"};
            foreach (var member in _assemblyTypes.SelectMany(type => type.GetMembers()))
            {
                if (excludePrefixes.Any(s => member.Name.StartsWith(s))) continue;
                var methodName = member.GetXmlDocsName();
                AssertContains(_xmlMemberNames, methodName);
            }
        }

        private static void AssertContains(IEnumerable<string> xmlMemberNames, string xmlName)
        {
            Assert.AreEqual(1, xmlMemberNames.Count(s => s == xmlName), xmlName);
        }

        [Test]
        public void TestMemberTypes()
        {
            Assert.AreEqual("M", MemberTypes.Constructor.GetXmlDocsName());
            Assert.AreEqual("T", MemberTypes.NestedType.GetXmlDocsName());
        }
    }
}