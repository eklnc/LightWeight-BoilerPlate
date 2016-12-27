using LWBoilerPlate.ComponentContracts;
using LWBoilerPlate.Models;
using LWBoilerPlate.Models.BaseModels;
using LWBoilerPlate.Models.Entities;
using LWBoilerPlate.Models.ViewModels;
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

            var exampleEntity = new LW_EXAMPLE { FullName = exampleModel.FullName };
            _exampleRepository.Insert(exampleEntity);

            return result;
        }
    }
}
