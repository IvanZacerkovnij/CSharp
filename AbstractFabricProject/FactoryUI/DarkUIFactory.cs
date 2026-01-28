using AbstractFabricProject.ButtonUI;
using AbstractFabricProject.TextBoxUI;

using AbstractFabricProject.TextBoxUI;

namespace AbstractFabricProject.FactoryUI;

public class DarkUIFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new Button(true);
    }

    public ITextBox CreateTextBox()
    {
        return new TextBox(true);
    }
}