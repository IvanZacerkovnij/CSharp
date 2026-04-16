namespace Homework4_EF.Interfaces;

public interface ICRUD<T>
{
    void Create(T model);
    void Update(T model);
    void Delete(int id);
    
    T? GetById(int id);
    IEnumerable<T>? GetAll();
}