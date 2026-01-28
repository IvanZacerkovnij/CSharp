using AbstractFabricProject.TextBoxUI;
using AbstractFabricProject.ButtonUI;

namespace AbstractFabricProject.FactoryUI;

interface IUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}