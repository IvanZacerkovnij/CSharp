using AbstractFabricProject.TextBoxUI;

namespace AbstractFabricProject.ButtonUI;

public class Button : IButton , IRender
{
    private string _text;

    public Button(bool mode)
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
        _text = "Light button";
    }

    public void DarkMode()
    {
        _text = "Dark button";
    }

    public void Render()
    {
        Console.WriteLine("Render " + _text); 
    }
}