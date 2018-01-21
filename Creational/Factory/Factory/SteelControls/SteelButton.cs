using Factory.AbstractControls;

namespace Factory.SteelControls
{
    class SteelButton : AbstractButton
    {
        public override void OnClick()
        {
            System.Console.WriteLine("Steel Button clicked.");
        }
    }
}
