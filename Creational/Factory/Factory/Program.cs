using Factory.AbstractControls;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Button:");
            System.Console.WriteLine();

            AbstractButton steelButton = ControlFactory.GetButton(ControlFactory.ButtonType.Steel);
            steelButton.OnClick();

            AbstractButton rubberButton = ControlFactory.GetButton(ControlFactory.ButtonType.Rubber);
            rubberButton.OnClick();

            System.Console.WriteLine();
            System.Console.WriteLine("Text Box:");
            System.Console.WriteLine();

            AbstractTextBox steelTextBox = ControlFactory.GetTextBox(ControlFactory.TextBoxType.Steel);
            steelTextBox.Show();

            AbstractTextBox rubberTextBox = ControlFactory.GetTextBox(ControlFactory.TextBoxType.Rubber);
            rubberTextBox.Show();

            AbstractTextBox woodTextBox = ControlFactory.GetTextBox(ControlFactory.TextBoxType.Wood);
            woodTextBox.Show();

            System.Console.WriteLine();
        }
    }
}
