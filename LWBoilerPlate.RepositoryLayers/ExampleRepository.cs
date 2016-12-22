using LWBoilerPlate.Models;
using LWBoilerPlate.RepositoryContracts;

namespace LWBoilerPlate.RepositoryLayers
{
    public class ExampleRepository : IExampleRepository
    {
        public BaseJsonResult ExampleFunction(ExampleViewModel exampleModel)
        {
            // bla bla bla db işlemleri

            return new BaseJsonResult { Success = true, Message = "İşleminiz başarı ile tamamlanmıştır." };
        }
    }
}
