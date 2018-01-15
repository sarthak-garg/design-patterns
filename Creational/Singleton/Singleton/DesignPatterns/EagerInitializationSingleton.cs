using System;

namespace Singleton.DesignPatterns
{
    class EagerInitializationSingleton
    {
        ///<summary>
        /// Private static instance of the same class.
        /// Initialized when the class is loaded.
        ///</summary>
        private static EagerInitializationSingleton instance = new EagerInitializationSingleton();

        ///<summary>
        /// Private constructor.
        ///</summary>
        private EagerInitializationSingleton() { }

        ///<summary>
        /// Public static method to return an instance of the class.
        ///</summary>
        public static EagerInitializationSingleton GetInstance()
        {
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
