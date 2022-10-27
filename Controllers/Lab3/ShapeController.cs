using Laboratorium_2_20_10_2022.Services.Lab3;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2_20_10_2022.Controllers.Lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(23, 23);
           
            return rectangle.getArea(); 
        }
        [HttpGet]
        public int sumArea()
        {
            var rectangle = new Rectangle(3, 3);
            var rectangle2 = new Rectangle(4, 4);

            return rectangle + rectangle2;

        }
    }
}
