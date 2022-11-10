using Laboratorium_2_20_10_2022.Services.Lab5;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2_20_10_2022.Controllers.Lab5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string GetLength()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}
