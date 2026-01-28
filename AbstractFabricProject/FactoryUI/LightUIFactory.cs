using System.Data.SqlTypes;
using AbstractFabricProject.TextBoxUI;
using AbstractFabricProject.ButtonUI;

namespace AbstractFabricProject.FactoryUI;

public class LightUIFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new Button(false);
    }

    public ITextBox CreateTextBox()
    {
        return new TextBox(false);
    }
}