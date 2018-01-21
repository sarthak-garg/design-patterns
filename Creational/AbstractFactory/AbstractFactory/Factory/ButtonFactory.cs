using AbstractFactory.Controls;

namespace AbstractFactory.Factory
{
    class ButtonFactory : UIAbstractFactory
    {
        public UIControl GetControl()
        {
            return new UIButton();
        }
    }
}
