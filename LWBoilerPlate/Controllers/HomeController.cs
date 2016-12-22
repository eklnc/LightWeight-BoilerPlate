using System.Web.Mvc;
using LWBoilerPlate.ComponentContracts;
using LWBoilerPlate.Models;

namespace LWBoilerPlate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExampleComponent _exampleComponent;

        public HomeController(IExampleComponent exampleComponent)
        {
            _exampleComponent = exampleComponent;
        }

        public ActionResult Index()
        {
            var exampleModel = new ExampleViewModel { FullName = "Emir Kılınç", Id = 22800 };

            BaseJsonResult result = _exampleComponent.ExampleFunction(exampleModel);

            return View();
        }
    }
}
