using LWBoilerPlate.Models;
using LWBoilerPlate.Models.BaseModels;
using LWBoilerPlate.Models.ViewModels;

namespace LWBoilerPlate.ComponentContracts
{
    public interface IExampleComponent
    {
        BaseJsonResult ExampleFunction(ExampleViewModel exampleModel);
    }
}
