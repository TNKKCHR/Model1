using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
    public class RestaurantController : Controller
    {
        [HttpGet("system/api/restaurant/list")]
        public ApiResult List()
        { 

        }
       
    }
}
