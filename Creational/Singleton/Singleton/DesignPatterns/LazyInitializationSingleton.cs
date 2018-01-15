using System;

namespace Singleton.DesignPatterns
{
    public class LazyInitializationSingleton
    {
        ///<summary>
        /// Private static instance of the same class.
        ///</summary>
        private static LazyInitializationSingleton instance;

        ///<summary>
        /// Private constructor.
        ///</summary>
        private LazyInitializationSingleton() { }

        ///<summary>
        /// Public static method to return an instance of the class.
        /// If the instance is null at first, then initializes it.
        ///</summary>
        public static LazyInitializationSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new LazyInitializationSingleton();
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
