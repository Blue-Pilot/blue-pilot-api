using Microsoft.AspNetCore.Mvc;
using Blue.Pilot.Domain.Catalog;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Blue.Pilot.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase {
        [HttpGet]
         public IActionResult GetItems() {
            var items = new List<Item>() {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item ("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };
             return Ok(items);
    }

    }

}