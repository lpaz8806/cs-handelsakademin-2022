namespace L08_FunctionalProgramming.Examples.Events;

public static class WindowExample
{
    public static void Run()
    {
        var w = InitWindow();

        while (true)
        {
            Console.Write("Write coordinates (top, left): ");
            var coords = Console.ReadLine().Split(',');
            var top = int.Parse(coords[0]);
            var left = int.Parse(coords[1]);

            w.Click(top, left);
        }
    }

    static Window InitWindow()
    {
        var okBtn = new Button("Ok", 0, 0, 10, 10);
        var cancelBtn = new Button("Cancel", 0, 15, 10, 10);

        var btn3 = new Button("Ok", 20, 0, 10, 10);
        var w = new Window();
        w.AddButton(okBtn);
        w.AddButton(cancelBtn);
        w.AddButton(btn3);

        okBtn.Clicked += (sender, args) =>
        {
            Console.WriteLine("User accepted");
        };
        
        cancelBtn.Clicked += (sender, args) =>
        {
            Console.WriteLine("User rejected");
        };

        btn3.Clicked += (sender, args) =>
        {
            Environment.Exit(0);
        };
        
        return w;
    }
}