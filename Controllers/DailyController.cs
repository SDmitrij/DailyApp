using DailyApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DailyApp.Controllers
{
    [Authorize]
    public class DailyController : BaseController
    {
        [HttpGet("index")]
        public JsonResult Index()
        {
            Daily daily = new Daily
            {
                Id = "qwerwerdzf",
                Name = "Russian ruble",
                Descr = "This is rus ruble"
            };

            return new JsonResult(daily);
        }
    }
}
