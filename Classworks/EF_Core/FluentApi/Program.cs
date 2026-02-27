using FluentApi.Configurator;
using FluentApi.Context;

namespace FluentApi;

class Program
{
    static void Main(string[] args)
    {
        using (var db = DbConfigurator.Configurator())
        {
            
        }
    }
}