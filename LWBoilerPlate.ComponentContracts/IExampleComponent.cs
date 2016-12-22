using LWBoilerPlate.Models;

namespace LWBoilerPlate.ComponentContracts
{
    public interface IExampleComponent
    {
        BaseJsonResult ExampleFunction(ExampleViewModel exampleModel);
    }
}
