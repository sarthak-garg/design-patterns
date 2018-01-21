using Factory.AbstractControls;
using Factory.RubberControls;
using Factory.SteelControls;
using Factory.WoodControls;

namespace Factory
{
    class ControlFactory
    {
        public enum ButtonType
        {
            Steel,
            Rubber
        }

        public enum TextBoxType
        {
            Steel,
            Rubber,
            Wood
        }

        public static AbstractButton GetButton(ButtonType type)
        {
            switch (type)
            {
                case ButtonType.Steel:
                    return new SteelButton();
                case ButtonType.Rubber:
                    return new RubberButton();
            }

            return null;
        }

        public static AbstractTextBox GetTextBox(TextBoxType type)
        {
            switch (type)
            {
                case TextBoxType.Steel:
                    return new SteelTextBox();
                case TextBoxType.Rubber:
                    return new RubberTextBox();
                case TextBoxType.Wood:
                    return new WoodTextBox();
            }

            return null;
        }
    }
}
