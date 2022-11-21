using static System.Console;

namespace hangman_menu;

public class Menu
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;

    public Menu(string prompt, string[] options)
    {
        Options = options;
        Prompt = prompt;
        SelectedIndex = 0;

    }

    private void DisplayOptions()
    {
        WriteLine(Prompt);
        for (int i = 0; i < Options.Length; i++)
        {
            string CurrentOptions = Options[i];
            string prefix;

            if (i == SelectedIndex)
            {
                prefix = "  ";
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
            }
            else
            {
                prefix = " ";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }

            WriteLine($"{prefix}<< {CurrentOptions} >>", CurrentOptions);
        }

        ResetColor();
    }

    public int Run()
    {
        ConsoleKey KeyPressed;
        do
        {
            Clear();
            DisplayOptions();
            
            ConsoleKeyInfo keyInfo = ReadKey(true);
            KeyPressed = keyInfo.Key;

            if (KeyPressed == ConsoleKey.UpArrow)
            {
                SelectedIndex--;
                if (SelectedIndex == -1)
                {
                    SelectedIndex = Options.Length - 1; 
                }
            }
            else if (KeyPressed == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if (SelectedIndex == 2)
                {
                    SelectedIndex = Options.Length + 2; 
                }
            }
            
            
            //update selected index with key

        } while (KeyPressed != ConsoleKey.Enter);
        
        
        return SelectedIndex;
    }
}

