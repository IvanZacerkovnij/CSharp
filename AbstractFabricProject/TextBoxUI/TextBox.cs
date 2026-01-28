using AbstractFabricProject.ButtonUI;

namespace AbstractFabricProject.TextBoxUI;

public class TextBox : ITextBox
{
    private string _text;
    public TextBox(bool mode)
    {
        if (!mode)
        {
            LightMode();
        }
        else
        {
            DarkMode();
        }
    }

    public void LightMode()
    {
        _text = "Light Button";
    }

    public void DarkMode()
    {
        _text = "Dark Button";
    }

    public void Render()
    {
        Console.WriteLine("Render " + _text);
    }
}
    
    