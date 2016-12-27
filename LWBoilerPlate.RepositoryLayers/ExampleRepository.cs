using System;
using System.Collections.Generic;
using System.Data.Entity;
using LWBoilerPlate.Models;
using LWBoilerPlate.Models.BaseModels;
using LWBoilerPlate.Models.Entities;
using LWBoilerPlate.Models.ViewModels;
using LWBoilerPlate.RepositoryContracts;

namespace LWBoilerPlate.RepositoryLayers
{
    public class ExampleRepository : GenericRepository<LW_EXAMPLE>, IExampleRepository
    {
        
        public BaseJsonResult ExampleFunction(ExampleViewModel exampleModel)
        {
            // bla bla bla db işlemleri
            
            return new BaseJsonResult { Success = true, Message = "İşleminiz başarı ile tamamlanmıştır." };
        }
    }
}
