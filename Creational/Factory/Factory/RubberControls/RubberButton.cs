using Factory.AbstractControls;

namespace Factory.RubberControls
{
    class RubberButton : AbstractButton
    {
        public override void OnClick()
        {
            System.Console.WriteLine("Rubber Button clicked.");
        }
    }
}
