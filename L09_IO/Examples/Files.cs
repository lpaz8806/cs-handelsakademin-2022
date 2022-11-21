using System.Text.Json;

namespace L09_IO.Examples;

public static class Files
{
    private const string PathToFile = "hello.txt";
    private const string PathToFolder = "/Users/lpaz/Projects/cs-handelsakademin-2022";
    
    static void RunReadAnimals()
    {
        using var sr = new StreamReader("animals.txt");
        while (true)
        {
            var json = sr.ReadLine();
            if(json == null)
                break;

            var animal = JsonSerializer.Deserialize<Animal>(json);
            Console.WriteLine(animal);
        }
    }
    static void RunSaveAnimal()
    {
        Console.Write("Gimmie the name: ");
        // ?? null-coalesce operator
        var name = Console.ReadLine() ?? string.Empty;
        
        Console.Write("Gimmie the race: ");
        var race = Console.ReadLine() ?? string.Empty;
        
        var tobby = new Animal
        {
            Name = name,
            Race = race
        };

        Console.WriteLine();
        var json = JsonSerializer.Serialize(tobby);
        
        using var sw = new StreamWriter("animals.txt", append: true);
        sw.WriteLine(json);
    }
    
    static void PrintFiles(string pathToFolder, Predicate<string> filter)
    {
        var files = Directory.GetFiles(pathToFolder);
        foreach (var file in files)
            if(filter(file))
                Console.WriteLine(file);

        var subfolders = Directory.GetDirectories(pathToFolder);
        foreach (var subfolder in subfolders)
            PrintFiles(subfolder, filter);
    }

    static void PrintFiles(
        string pathToFolder,
        Predicate<string> filter,
        Action<string> action)
    {
        var files = Directory.GetFiles(pathToFolder);
        foreach (var file in files)
            if(filter(file))
                action(file);

        var subfolders = Directory.GetDirectories(pathToFolder);
        foreach (var subfolder in subfolders)
            PrintFiles(subfolder, filter, action);
    }

    static void PrintFiles(string pathToFolder)
    {
        var files = Directory.GetFiles(pathToFolder);
        Console.WriteLine(string.Join("\n", files));

        Console.Write("Press any key to continue...");
        Console.ReadKey(true);
        Console.WriteLine();
        
        var subfolders = Directory.GetDirectories(pathToFolder);
        foreach (var subfolder in subfolders)
            PrintFiles(subfolder);
    }
}