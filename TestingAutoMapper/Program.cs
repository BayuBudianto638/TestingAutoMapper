using AutoMapper;
using TestingAutoMapper.Configuration;
using TestingAutoMapper.Models;
using TestingAutoMapper.ViewModels;

class Program
{
    static void Main()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<ConfigProfile>();
        });

        var mapper = config.CreateMapper();

        var vm = new ClassVM { Id = 1, Name = "John Doe" };
        var modelA = mapper.Map<ClassA>(vm);
        var modelB = mapper.Map<ClassB>(vm);
        Console.ReadKey();
    }
}