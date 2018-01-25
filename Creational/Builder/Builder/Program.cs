using Builder.PhoneBuilders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhoneBuilder androidBuilder = new AndroidPhoneBuilder();
            IPhoneBuilder appleBuilder = new ApplePhoneBuilder();

            Director director = new Director();

            director.Construct(androidBuilder);
            director.Construct(appleBuilder);

            System.Console.WriteLine(androidBuilder.GetPhone().ToString());
            System.Console.WriteLine(appleBuilder.GetPhone().ToString());
            System.Console.WriteLine();
        }
    }
}
