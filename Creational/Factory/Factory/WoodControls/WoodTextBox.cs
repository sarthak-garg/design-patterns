using Factory.AbstractControls;

namespace Factory.WoodControls
{
    class WoodTextBox : AbstractTextBox
    {
        public override void Show()
        {
            System.Console.WriteLine("Text in Wood TextBox: xxxxx");
        }
    }
}
