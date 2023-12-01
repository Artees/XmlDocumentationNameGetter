// ReSharper disable UnusedMember.Global, UnusedParameter.Global
using System;
using System.Collections.Generic;

namespace XmlDocumentationNameGetterTestAssembly
{
    /// <summary>
    /// GenericClass summary
    /// </summary>
    public class GenericClass<T>
    {
        /// <summary>
        /// Constructor summary
        /// </summary>
        // ReSharper disable once EmptyConstructor
        public GenericClass()
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
        public void Method(T arg)
        {
            
        }
        
        /// <summary>
        /// Method summary
        /// </summary>
        public void Method<TMethod>(T aType, TMethod aMethod)
        {
            
        }
        
        /// <summary>
        /// Method summary
        /// </summary>
        public void Method<TMethod0, TMethod1>(T aType, TMethod0 aMethod0, TMethod1 aMethod1)
        {
            
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method(IEnumerable<T> arg)
        {
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method<TMethod>(Tuple<T, TMethod> arg)
        {
        }
        

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method(out T arg)
        {
            arg = default(T);
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void MethodGenericOut<TMethod>(out TMethod arg)
        {
            arg = default(TMethod);
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void MethodGenericOut<TMethod>(out TMethod arg1, out T arg2)
        {
            arg1 = default(TMethod);
            arg2 = default(T);
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void MethodGenericRef<TMethod>(ref TMethod arg1, ref T arg2)
        {
            arg1 = default(TMethod);
            arg2 = default(T);
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