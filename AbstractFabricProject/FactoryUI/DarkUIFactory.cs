using AbstractFabricProject.ButtonUI;
using AbstractFabricProject.TextBoxUI;

using AbstractFabricProject.TextBoxUI;

namespace AbstractFabricProject.FactoryUI;

public class DarkUIFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ITextBox CreateTextBox()
    {
        return new LightTextBox();
    }
}