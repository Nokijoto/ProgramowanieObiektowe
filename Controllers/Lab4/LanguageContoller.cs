using Laboratorium_2_20_10_2022.Services.Lab4;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Laboratorium_2_20_10_2022.Controllers.Lab4
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class LanguageContoller :ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("Polski");
            return lang.getLang();
        }
        [HttpGet]
        public void Index()
        {
            
        
        }
        
    }
}
