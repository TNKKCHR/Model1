using Microsoft.AspNetCore.Mvc;
using Model1.Models;
using System.Runtime.Intrinsics.Arm;

namespace Model1.Controllers
{
    public class RestaurantController : Controller
    {
        [HttpGet("system/api/restaurant/list")]
        public ApiResult List(iny pageNum = 1, int pageSize = 10,
            string? restaurantName = null, string? restaurantType = null)
        {
            var q = Dp.Restaurant.AsQueryable();

            q = q.Where(x => x.RestaurantName.Contains(restaurantName));


            return ApiResult.IsNullorEmty(restaurantName))
                
        }
       
    }
}
