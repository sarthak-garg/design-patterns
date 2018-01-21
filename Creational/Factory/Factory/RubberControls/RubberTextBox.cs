using Factory.AbstractControls;

namespace Factory.RubberControls
{
    class RubberTextBox : AbstractTextBox
    {
        public override void Show()
        {
            System.Console.WriteLine("Text in Rubber TextBox: xxxxx");
        }
    }
}
