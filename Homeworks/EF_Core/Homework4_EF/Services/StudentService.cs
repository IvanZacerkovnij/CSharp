using Homework4_EF.Entities;
using Homework4_EF.Interfaces;
using Homework4_EF.Repositories;

namespace Homework4_EF.Services;

public class StudentService(StudentRepository _repo) : IService<Student>
{
    public void Add(Student entity)
    {
        _repo.Create(entity);
    }

    public void Update(Student entity)
    {
        _repo.Update(entity);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }

    public Student? GetById(int id)
    {
        return _repo.GetById(id);
    }

    public IEnumerable<Student>? GetAll()
    {
        return _repo.GetAll();
    }
}