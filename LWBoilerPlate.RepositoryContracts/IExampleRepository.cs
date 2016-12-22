using LWBoilerPlate.Models;

namespace LWBoilerPlate.RepositoryContracts
{
    public interface IExampleRepository
    {
        BaseJsonResult ExampleFunction(ExampleViewModel exampleModel);
    }
}
