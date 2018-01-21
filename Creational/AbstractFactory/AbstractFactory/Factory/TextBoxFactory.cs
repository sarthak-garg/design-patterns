using AbstractFactory.Controls;

namespace AbstractFactory.Factory
{
    class TextBoxFactory : UIAbstractFactory
    {
        public UIControl GetControl()
        {
            return new UITextBox();
        }
    }
}
