using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Artees.Tools.XmlDocumentationNameGetter
{
    /// <summary>
    /// Extension methods that allow you to get the name of a type or a member that corresponds to
    /// the XML documentation convention.
    /// </summary>
    public static class XmlDocumentationNameGetterExtensions
    {
        private static readonly Dictionary<MemberTypes, string> XmlMemberTypes =
            new Dictionary<MemberTypes, string>
            {
                {MemberTypes.All, "?"},
                {MemberTypes.Constructor, "M"},
                {MemberTypes.Custom, "?"},
                {MemberTypes.Event, "E"},
                {MemberTypes.Field, "F"},
                {MemberTypes.Method, "M"},
                {MemberTypes.NestedType, "T"},
                {MemberTypes.Property, "P"},
                {MemberTypes.TypeInfo, "T"}
            };

        /// <summary>
        /// Returns the name of the member that corresponds to the XML documentation convention.
        /// </summary>
        public static string GetXmlDocsName(this MemberInfo member)
        {
            return $"{GetMemberType(member)}:{GetFullMemberName(member)}";
        }

        private static string GetMemberType(MemberInfo member)
        {
            return GetXmlDocsName(member.MemberType);
        }
        
        /// <summary>
        /// Returns the name of the member's type that corresponds to the XML documentation
        /// convention.
        /// </summary>
        public static string GetXmlDocsName(this MemberTypes memberType)
        {
            return XmlMemberTypes[memberType];
        }

        private static string GetFullMemberName(MemberInfo member)
        {
            var type = member.MemberType == MemberTypes.TypeInfo
                ? (Type) member
                : member.ReflectedType;
            var typeName = GetTypeName(type);
            var memberName = GetMemberName(member);
            return $"{typeName}{memberName}";
        }

        private static string GetTypeName(Type type)
        {
            if (type.IsGenericParameter) return "``0";
            var genericArgs = GetGenericTypeArgsString(type);
            var f = type.FullName ?? $"{type.Namespace}.{type.Name}";
            var g = string.IsNullOrEmpty(genericArgs) ? f : f.Split('`')[0];
            var typeName = g.Replace('+', '.');
            return $"{typeName}{genericArgs}";
        }

        private static string GetGenericTypeArgsString(Type type)
        {
            var genericTypeArguments = type.GenericTypeArguments;
            if (genericTypeArguments.Length == 0) return string.Empty;
            var genericArgsNames = genericTypeArguments.Select(GetTypeName).ToArray();
            var genericArgsJoined = string.Join(",", genericArgsNames);
            return $"{{{genericArgsJoined}}}";
        }

        private static string GetMemberName(MemberInfo member)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (member.MemberType)
            {
                case MemberTypes.TypeInfo:
                    return string.Empty;
                case MemberTypes.Method:
                case MemberTypes.Constructor:
                    return GetMethodName((MethodBase) member);
            }

            return $".{member.Name}";
        }

        private static string GetMethodName(MethodBase method)
        {
            var name = method.Name.Replace(".ctor", "#ctor");
            var generic = GetGenericArgsString(method);
            var param = GetParametersName(method);
            return $".{name}{generic}{param}";
        }

        private static string GetGenericArgsString(MethodBase method)
        {
            return method.IsGenericMethod
                ? $"``{method.GetGenericArguments().Length}"
                : string.Empty;
        }

        private static string GetParametersName(MethodBase method)
        {
            var parameters = method.GetParameters();
            if (parameters.Length == 0) return string.Empty;
            var paramNames = parameters.Select(p => GetTypeName(p.ParameterType));
            var paramJoined = string.Join(",", paramNames.ToArray());
            return $"({paramJoined})";
        }
    }
}