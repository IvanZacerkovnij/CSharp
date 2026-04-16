using Homework4_EF.Entities;
using Homework4_EF.Interfaces;
using Homework4_EF.Repositories;

namespace Homework4_EF.Services;

public class GradeService(GradeRepository _repo) : IService<Grade>
{
    public void Add(Grade entity)
    {
        _repo.Create(entity);
    }

    public void Update(Grade entity)
    {
        _repo.Update(entity);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }

    public Grade? GetById(int id)
    {
        return _repo.GetById(id);
    }

    public IEnumerable<Grade>? GetAll()
    {
        return _repo.GetAll();
    }
}