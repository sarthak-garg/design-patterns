using AbstractFactory.Controls;

namespace AbstractFactory.Factory
{
    public interface UIAbstractFactory
    {
        UIControl GetControl();
    }
}
