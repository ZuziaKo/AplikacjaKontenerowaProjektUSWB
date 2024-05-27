using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class BackendController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<FoodItem> foodItems = new List<FoodItem>
            {
                new FoodItem { Id = 1, Name = "Pizza", Description = "Pepperoni pizza", Price = "40z³"},
                new FoodItem { Id = 2, Name = "Burger", Description = "Cheeseburger", Price = "30z³" },
                new FoodItem { Id = 3, Name = "Sushi", Description = "California roll", Price = "25z³" }
            };

            return Ok(foodItems);
        }
    }
}
