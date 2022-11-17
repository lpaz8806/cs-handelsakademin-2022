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

    public void Display()
    {
        Console.Clear();
        foreach (var button in _buttons)
        {
            button.Display();
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

    public void Display()
    {
        var hLine = new string('*', Width);
        var vLine = '*' + new string(' ', Width -2) + '*';

        Console.SetCursorPosition( Left, Top);
        Console.Write(hLine);
        for (int i = 0; i < Height -2; i++)
        {
            Console.SetCursorPosition( Left, Top + i + 1);
            Console.Write(vLine);
        }

        Console.SetCursorPosition(Left, Top + Height - 1);
        Console.Write(hLine);

        Console.SetCursorPosition(Left + 2, (Top + Height) / 2);
        Console.Write(Text);
    }
}