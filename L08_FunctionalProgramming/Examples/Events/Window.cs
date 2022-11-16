namespace L08_FunctionalProgramming.Examples.Events;

public class Window
{
    private List<Button> _buttons = new();
    
    public void Click(int top, int left)
    {
        foreach (var button in _buttons)
        {
            var isInside =
                top >= button.Top &&
                top <= button.Top + button.Height &&
                left >= button.Left &&
                left <= button.Left + button.Width;
                
            if(isInside)
                button.Click();
        }
    }
    
    public void AddButton(Button b)
    {
        _buttons.Add(b);
    }
}

public class Button
{
    public string Text { get; }
    public int Top { get; }
    public int Left { get; }
    public int Width { get; }
    public int Height { get; }

    public Button(string text, int top, int left, int width, int height)
    {
        Text = text;
        Top = top;
        Left = left;
        Width = width;
        Height = height;
    }
    
    public event EventHandler Clicked;
    public void Click()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}