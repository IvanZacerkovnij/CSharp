using Homework4_EF.Entities;
using Homework4_EF.Interfaces;
using Homework4_EF.Repositories;

namespace Homework4_EF.Services;

public class SubjectService(SubjectRepository _repo) : IService<Subject>
{
    public void Add(Subject entity)
    {
        _repo.Create(entity);
    }

    public void Update(Subject entity)
    {
        _repo.Update(entity);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }

    public Subject? GetById(int id)
    {
        return _repo.GetById(id);
    }

    public IEnumerable<Subject>? GetAll()
    {
        return _repo.GetAll();
    }
}