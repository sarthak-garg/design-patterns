using AbstractFactory.Controls;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            UIControl button = ControlFactory.GetControl(new ButtonFactory());
            button.Draw();
            System.Console.WriteLine();

            UIControl textBox = ControlFactory.GetControl(new TextBoxFactory());
            textBox.Draw();
            System.Console.WriteLine();
        }
    }
}
