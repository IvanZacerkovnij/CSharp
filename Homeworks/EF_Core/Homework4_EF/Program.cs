using Homework4_EF.Configurators.ContextConfigurators;
using Homework4_EF.Context;
using Homework4_EF.Entities;
using Homework4_EF.Interfaces;
using Homework4_EF.Repositories;
using Homework4_EF.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Homework4_EF;

class Program
{
    static void Main(string[] args)
    {
        var provider = new ServiceCollection();
        provider.AddDbContext<AcademyDbContext>(options => Configurator.Configure(options));

        provider.AddScoped<IService<Subject>, SubjectService>();
        provider.AddScoped<IService<Student>, StudentService>();
        provider.AddScoped<IService<Curator>, CuratorService>();
        provider.AddScoped<IService<Grade>, GradeService>();
        provider.AddScoped<IService<Group>, GroupService>();

        provider.AddScoped<ICRUD<Subject>,SubjectRepository>();
        provider.AddScoped<ICRUD<Student>,StudentRepository>();
        provider.AddScoped<ICRUD<Grade>,GradeRepository>();
        provider.AddScoped<ICRUD<Group>,GroupRepository>();
        provider.AddScoped<ICRUD<Curator>,CuratorRepository>();
        
        var serviceProvider = provider.BuildServiceProvider();
    }
}