using System;
// ReSharper disable UnusedMember.Global

namespace XmlDocumentationNameGetterTestAssembly
{
    /// <summary>
    /// GenericClassWithConstraint summary
    /// </summary>
    /// <typeparam name="T"></typeparam>
    // ReSharper disable once UnusedMember.Global
    // ReSharper disable once UnusedTypeParameter
    public class GenericClassWithConstraint<T> where T:IDisposable
    {
        /// <summary>
        /// Constructor summary
        /// </summary>
        // ReSharper disable once EmptyConstructor
        public GenericClassWithConstraint()
        {
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method()
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