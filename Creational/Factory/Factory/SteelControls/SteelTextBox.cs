using Factory.AbstractControls;

namespace Factory.SteelControls
{
    class SteelTextBox : AbstractTextBox
    {
        public override void Show()
        {
            System.Console.WriteLine("Text in Steel TextBox: xxxxx");
        }
    }
}
