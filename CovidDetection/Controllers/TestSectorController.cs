using CovidDetection.DTOs;
using CovidDetection.Services.DataServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CovidDetection.Controllers
{

    public class TestSectorController : Controller

    {
        public readonly IDataService _dS;

        public TestSectorController(IDataService dS)
             {
                  _dS = dS;
             }

        [Authorize]
        [HttpGet]
        public IActionResult Enter()
        {
            return View("FormView");
        }

        [Authorize]
        
        [HttpPost]
        public  IActionResult Collect([FromForm] FormDTO data)
        {
            



            _ =  _dS.sendResult(data);

            return View("ThankYou");
       
        }
    }
}
