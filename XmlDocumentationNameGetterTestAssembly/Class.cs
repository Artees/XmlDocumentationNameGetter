// ReSharper disable UnusedMember.Global, UnusedTypeParameter, UnusedParameter.Global

using System;
using System.Collections.Generic;

namespace XmlDocumentationNameGetterTestAssembly
{
    /// <summary>
    /// Class summary
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Event summary
        /// </summary>
#pragma warning disable 67
        // ReSharper disable once EventNeverSubscribedTo.Global
        public event Action<int, int> Event;
#pragma warning restore 67

        /// <summary>
        /// Field summary
        /// </summary>
        public Tuple<int, int> Field;

        /// <summary>
        /// _field summary
        /// </summary>
        private Tuple<int, int> _field;

        /// <summary>
        /// Property summary
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public Tuple<int, int> Property
        {
            get => _field;
            set => _field = value;
        }

        /// <summary>
        /// Constructor summary
        /// </summary>
        // ReSharper disable once EmptyConstructor
        public Class()
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
        public void Method(int arg0, int arg1)
        {
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method(IEnumerable<int> arg)
        {
        }

        /// <summary>
        /// Method summary
        /// </summary>
        public void Method(Tuple<int, int> arg)
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        /// <typeparam name="T">GenericMethod typeparam</typeparam>
        public void GenericMethod<T>()
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        /// <typeparam name="T0">GenericMethod typeparam T0</typeparam>
        /// <typeparam name="T1">GenericMethod typeparam T1</typeparam>
        public void GenericMethod<T0, T1>()
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        /// <typeparam name="T0">GenericMethod typeparam T0</typeparam>
        /// <typeparam name="T1">GenericMethod typeparam T1</typeparam>
        /// <typeparam name="T2">GenericMethod typeparam T2</typeparam>
        public void GenericMethod<T0, T1, T2>()
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        /// <typeparam name="T">GenericMethod typeparam</typeparam>
        public void GenericMethod<T>(int arg)
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        /// <typeparam name="T">GenericMethod typeparam</typeparam>
        public void GenericMethod<T>(int arg0, T arg1, int arg2)
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        /// <typeparam name="T">GenericMethod typeparam</typeparam>
        public void GenericMethod<T>(T arg0, int arg1, T arg2)
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        public void GenericMethod<T>(IEnumerable<T> arg)
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        public void GenericMethod<T>(Tuple<T, int> arg)
        {
        }

        /// <summary>
        /// GenericMethod summary
        /// </summary>
        public void GenericMethod<T>(Tuple<T, T> arg)
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
        
        /// <summary>
        /// NestedClass summary
        /// </summary>
        public class NestedClass
        {
            /// <summary>
            /// Constructor summary
            /// </summary>
            // ReSharper disable once EmptyConstructor
            public NestedClass()
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
}