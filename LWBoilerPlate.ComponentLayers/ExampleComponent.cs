using LWBoilerPlate.ComponentContracts;
using LWBoilerPlate.Models;
using LWBoilerPlate.RepositoryContracts;

namespace LWBoilerPlate.ComponentLayers
{
    public class ExampleComponent : IExampleComponent
    {
        private readonly IExampleRepository _exampleRepository;

        public ExampleComponent(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }
        
        public BaseJsonResult ExampleFunction(ExampleViewModel exampleModel)
        {
            BaseJsonResult result = _exampleRepository.ExampleFunction(exampleModel);

            return result;
        }
    }
}
