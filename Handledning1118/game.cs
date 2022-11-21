namespace hangman_menu;


public class Game
{
    static string[] words =
    {
        "dog", "carrot", "hangman", "ganjaman", "xanax",
        "car", "handstanding", "sixtynine", "apple", "pie"
    };

    private Random random = new(); //creates a new object "random"
    private string chosenWord; //The random chosen word
    private int lives = 6; //number of tries the user can use 
    private List<char> guessedLetters = new(); //keeps track of allready guessed lettes
    private string displayWord;

    private char[] mask;
    // car
    
    public void Start()
    {
        chosenWord = GetRandomWord();
        InitializeMask(chosenWord);
        
        while (true)
        {
            ShowUserInterface();

            if (lives == 0)
            {
                ShowLooseMessage();
                return;
            }
            
            if (!mask.Contains('_'))
            {
                ShowWinMessage();
                return;
            }

            var guess = ReadUserGuess("Your guess: ");

            if(guessedLetters.Contains(guess))
                continue;
            
            guessedLetters.Add(guess); //adds letter to the list

            if (chosenWord.Contains(guess))
                UpdateMask(guess);
            else
                lives--;
        }
    }

    private void ShowUserInterface()
    {
        Console.Clear();
        Hangman();
        Console.WriteLine();
        Console.WriteLine($"Lives: {lives} ");
        Console.WriteLine($"The choosen word has {chosenWord.Length} letters in it\n");
        Console.Write("Letters you have guessed: ");
        PrintUsedLetters();
        Console.WriteLine();
        PrintMask();
        Console.WriteLine();
    }

    void Hangman()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
  _    _                                         
 | |  | |                                        
 | |__| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
 |  __  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
 | |  | | (_| | | | | (_| | | | | | | (_| | | | |
 |_|  |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                      __/ |                      
                     |___/                       
");
        Console.ResetColor(); 

    }

    private void ShowWinMessage()
    {
        Console.Clear();
        Won();
        Console.WriteLine("Congrats! Press any key to succeed");
        Console.ReadKey();
        runMainMenu();
        Console.ReadKey();
    }

    private void ShowLooseMessage()
    {
        Console.Clear();
        Hanged();
        Console.WriteLine("You ran out of attempts!  ");
        Console.WriteLine($"The right word was: {chosenWord}", chosenWord);
        Console.WriteLine("Press any key to succeed");
        Console.ReadKey();
        runMainMenu();
        Console.ReadKey();
    }

    void runMainMenu()
    {
        string prompt = "What do you want to do?";
        Console.WriteLine("Use the arrowkeys to navigate and use enter to select");
        string[] options = { "Exit the game", "Play again" };
        Menu mainMenu = new Menu(prompt, options);
        int selectedIndex = mainMenu.Run();

        switch (selectedIndex)
        {
            case 0:
                ExitGame();
                break;
            case 1:
                playAgain();
                break;
        }
    }

    void ExitGame()
    {
        Console.Clear();
        Environment.Exit(0);
    }

    void playAgain()
    {
        Console.Clear();
        Start();
    }
    
    void Won()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
██    ██  ██████  ██    ██     ██     ██  ██████  ███    ██ ██ ██ 
 ██  ██  ██    ██ ██    ██     ██     ██ ██    ██ ████   ██ ██ ██ 
  ████   ██    ██ ██    ██     ██  █  ██ ██    ██ ██ ██  ██ ██ ██ 
   ██    ██    ██ ██    ██     ██ ███ ██ ██    ██ ██  ██ ██       
   ██     ██████   ██████       ███ ███   ██████  ██   ████ ██ ██ 
                                                                  
                                                                                     
");
        Console.ResetColor(); 

    }
    void Hanged()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"
▓██   ██▓ ▒█████   █    ██  ██▀███  ▓█████     ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄  ▐██▌    
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒▓██ ▒ ██▒▓█   ▀    ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌ ▐██▌    
  ▒██ ██░▒██░  ██▒▓██  ▒██░▓██ ░▄█ ▒▒███      ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌ ▐██▌    
  ░ ▐██▓░▒██   ██░▓▓█  ░██░▒██▀▀█▄  ▒▓█  ▄    ░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌ ▓██▒    
  ░ ██▒▓░░ ████▓▒░▒▒█████▓ ░██▓ ▒██▒░▒████▒   ░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓  ▒▄▄     
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░░░ ▒░ ░    ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒  ░▀▀▒    
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░   ░▒ ░ ▒░ ░ ░  ░    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒  ░  ░    
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░   ░░   ░    ░       ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░     ░    
 ░ ░         ░ ░     ░        ░        ░  ░    ░  ░  ░      ░  ░         ░       ░    ░  ░   ░     ░       
 ░ ░                                                                                       ░               
                                                                                 
");
        Console.ResetColor(); 

    }

    char ReadUserGuess(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        return string.IsNullOrEmpty(input)
            ? default
            : input[0];
    }
    
    string GetRandomWord()
    {
        int wordsList; //Chooses a index between 0 and the lenght of the string words.
        wordsList = random.Next(0, words.Length); //Chooses a index between 0 and the lenght of the string words.
        return words[wordsList].ToLower(); //The random chosen word
    }

    void InitializeMask(string word)
    {
        mask = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
            mask[i] = '_';
    }

    void PrintMask()
    {
        Console.WriteLine(string.Join(" ", mask));
    }
    
    void UpdateMask(char guessedLetter)
    {
        for (int i = 0; i < chosenWord.Length; i++)
            if (chosenWord[i] == guessedLetter)
                mask[i] = guessedLetter;
    }

    void PrintUsedLetters()
    {
        Console.WriteLine(string.Join(" ", guessedLetters));
    }
}

