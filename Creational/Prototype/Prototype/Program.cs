
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Potato potato1 = new Potato();
            potato1.Name = "Pato";
            potato1.Details.OwnerName = "Sarthak";

            Potato potato2 = potato1.Clone() as Potato;
            potato2.Details.OwnerName = "Garg";

            // It is evident that the Details object is not shared by reference across the 2 potatoes
            System.Console.WriteLine("Potato 1: " + potato1.Name + " " + potato1.Details.OwnerName);
            System.Console.WriteLine("Potato 2: " + potato2.Name + " " + potato2.Details.OwnerName);
            System.Console.WriteLine();
        }
    }
}
