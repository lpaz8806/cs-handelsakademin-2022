using L09_IO.Db;

namespace L09_IO.Examples;

public interface IBrandRepository
{
    List<Brand> GetAll();
    List<Brand> SearchByDescription(string searchTerm);

    void Save(Brand b);
}