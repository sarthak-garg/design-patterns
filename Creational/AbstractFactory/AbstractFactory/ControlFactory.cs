using AbstractFactory.Controls;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class ControlFactory
    {
        public static UIControl GetControl(UIAbstractFactory factory)
        {
            return factory.GetControl();
        }
    }
}
