using System.Data.SqlTypes;
using AbstractFabricProject.TextBoxUI;
using AbstractFabricProject.ButtonUI;

namespace AbstractFabricProject.FactoryUI;

public class LightUIFactory : IUIFactory
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