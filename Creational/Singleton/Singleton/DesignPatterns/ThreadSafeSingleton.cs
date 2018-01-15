using System;

namespace Singleton.DesignPatterns
{
    class ThreadSafeSingleton
    {
        ///<summary>
        /// Private static instance of the same class.
        ///</summary>
        private static ThreadSafeSingleton instance;

        ///<summary>
        /// Object to lock the GetInstance method to ensure Thread Safety.
        ///</summary>
        private static readonly object padlock = new object();

        ///<summary>
        /// Private constructor.
        ///</summary>
        private ThreadSafeSingleton() { }

        ///<summary>
        /// Public static method to return an instance of the class.
        ///</summary>
        public static ThreadSafeSingleton GetInstance()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }

            return instance;
        }

        ///<summary>
        /// Test the instance of the class.
        ///</summary>
        public void TestInstance()
        {
            Console.WriteLine("Instance Type: {0}.", instance.GetType());
        }
    }
}
