// ReSharper disable UnusedMember.Global, EmptyConstructor, UnusedParameter.Global
using System;

namespace XmlDocumentationNameGetterTestAssembly
{
    /// <summary>
    /// GenericClassWithTwoConstraints summary
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <typeparam name="T1"></typeparam>
    public class GenericClassWithTwoConstraints<T0, T1>
    {
        /// <summary>
        /// Constructor summary
        /// </summary>
        public GenericClassWithTwoConstraints()
        {
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method()
        {
            
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method(T0 arg0, T1 arg1)
        {
            
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method(Tuple<T0, T1> arg)
        {
        }
        
        /// <summary>
        /// Equals summary
        /// </summary>
        /// <param name="obj">Equals param</param>
        /// <returns>Equals returns</returns>
        public override bool Equals(object obj)
        {
            return false;
        }

        /// <summary>
        /// GetHashCode summary
        /// </summary>
        /// <returns>GetHashCode returns</returns>
        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// GetType summary
        /// </summary>
        /// <returns>GetType returns</returns>
        public new Type GetType()
        {
            return null;
        }

        /// <summary>
        /// ToString summary
        /// </summary>
        /// <returns>ToString returns</returns>
        public override string ToString()
        {
            return "ToString";
        }
    }
}