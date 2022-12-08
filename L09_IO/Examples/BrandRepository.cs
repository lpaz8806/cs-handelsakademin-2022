using L09_IO.Db;

namespace L09_IO.Examples;
using MySqlConnector;

public class BrandRepository : IBrandRepository, IDisposable
{
    private MySqlConnection conn;

    public BrandRepository(MySqlConnection conn)
    {
        this.conn = conn; // this is weird
    }

    public void Dispose()
    {
        conn.Dispose();
    }

    public List<Brand> GetAll()
    {
        conn.Open();

        var query = "SELECT * FROM brands";
        using var command = new MySqlCommand(query, conn);

        var reader = command.ExecuteReader();
        var brands = new List<Brand>();
        // hydrate a list of brand
        while (reader.Read())
        {
            // hydrate an object
            var brand = new Brand
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name")
            };
            brands.Add(brand);
        }
        
        conn.Close();
        return brands;
    }

    public List<Brand> SearchByDescription(string searchTerm)
    {
        conn.Open();

        var query = "SELECT * FROM brands WHERE name LIKE @pattern";
        using var command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@pattern", $"%{searchTerm}%");

        var reader = command.ExecuteReader();
        var brands = new List<Brand>();
        // hydrate a list of brand
        while (reader.Read())
        {
            // hydrate an object
            var brand = new Brand
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name")
            };
            brands.Add(brand);
        }
        
        conn.Close();
        return brands;
    }

    public void Save(Brand b)
    {
        if(b.Id == 0)
            Insert(b);
        else
            Update(b);
    }
    
    private void Insert(Brand b)
    {
        conn.Open();
        var query = "INSERT INTO brands(name) VALUES(@name)";
        using var command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@name", b.Name);
        command.ExecuteNonQuery();
        conn.Close();
    }
    private void Update(Brand b)
    {
        conn.Open();
        var query = "UPDATE brands SET name = @name WHERE id = @id";
        using var command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@name", b.Name);
        command.Parameters.AddWithValue("@id", b.Id);
        command.ExecuteNonQuery();
        conn.Close();
    }
}