using Singleton.DesignPatterns;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lazy Initialization Singleton Design Pattern
            LazyInitializationSingleton lazyInitializationSingleton = LazyInitializationSingleton.GetInstance();
            lazyInitializationSingleton.TestInstance();

            // Eager Initialization Singleton Design Pattern
            EagerInitializationSingleton eagerInitializationSingleton = EagerInitializationSingleton.GetInstance();
            eagerInitializationSingleton.TestInstance();
        }
    }
}
