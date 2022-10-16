using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace healthcare_web_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_nameController : ControllerBase
    {

        public List<string> category_names_controller { get; set; } = new List<string>
        {"Gastro", "Vitamin"};

        [HttpGet]
        public async Task<ActionResult<List<string>>> Get()
        {

            return Ok(category_names_controller);
        }

    }
}
