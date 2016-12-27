using LWBoilerPlate.Models;
using LWBoilerPlate.Models.BaseModels;
using LWBoilerPlate.Models.Entities;
using LWBoilerPlate.Models.ViewModels;

namespace LWBoilerPlate.RepositoryContracts
{
    public interface IExampleRepository : IGenericRepository<LW_EXAMPLE>
    {
        BaseJsonResult ExampleFunction(ExampleViewModel exampleModel);
    }
}
