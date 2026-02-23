using AbstractFabricProject.ButtonUI;
using AbstractFabricProject.FactoryUI;
using AbstractFabricProject.TextBoxUI;

namespace AbstractFabricProject;

class Program
{
    static void Main(string[] args)
    {
        IUIFactory factory = new LightUIFactory();
        
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        button.Render();
        textBox.Render();
    }
}