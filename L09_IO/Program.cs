/*
Class Libraries
[X] Motivation
[X] Creation
[X] Usage

IO
[X] File, read / write
[X] Resources, IDisposable
[X] File System Traversal
[X] Serialization (JSON in particular)

DB
[X] Connect to MySql
[X] Consuming data from DB
[ ] init accessor
 */

using L09_IO.Db;
using L09_IO.Examples;
using MySqlConnector;

class Program
{
    static void Main()
    {
        var repo = GetBrandRepo();
        RunSave(repo);
    }

    static void RunSave(IBrandRepository repo)
    {
        var hm = new Brand
        {
            Name = "H&M"
        };
        repo.Save(hm);
    }
    
    static void RunSearch(IBrandRepository repo)
    {
        Console.Write("Search foo by description: ");
        var searchTerm = Console.ReadLine();
        var brands = repo.SearchByDescription(searchTerm);

        var output = brands.Count == 0
            ? "Nothing Found"
            : string.Join("\n", brands);
        Console.WriteLine(output);
    }

    static IBrandRepository GetBrandRepo()
    {
        var connectionString = File.ReadAllLines("config.txt")[0];
        var conn = new MySqlConnection(connectionString);
        return new BrandRepository(conn);
    }
}