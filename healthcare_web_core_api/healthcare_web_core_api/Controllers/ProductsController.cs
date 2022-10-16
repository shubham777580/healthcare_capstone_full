using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace healthcare_web_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static List<Products> product_list = new List<Products>
            {
                new Products
                {
                    id = 1,
                    title = "Digene Acidity & Gas Relief Tablets - Mint Flavour 15's",
                    price = 20,
                    description = "Digene Tablet provides relief from acidity and gas whenever acidity strikes. It has a sugar-free formulation that provides effective action against acidity, reduces stomach pain and protects the stomach from making excess acid for long-lasting relief. Digene Antacid Tablet comes in a handy pack that can be kept within easy reach at home. Its scientifically developed combination of active ingredients provides a High ANC (Acid Neutralising Capacity) property.",
                    category = "Gastro",
                    image = "https://www.netmeds.com/images/product-v1/600x600/896035/digene_tablets_for_acidity_gas_relief_mint_flavour_15s_0_2.jpg"

                },

                new Products
                {
                    id = 2,
                    title = "Supradyn Daily Multivitamin Tablet with Minerals 15's",
                    price = 50,
                    description = "New Supradyn Daily Tablets contain 12 vitamins, 5 trace elements, 2 minerals & 1 amino acid that contribute in enhancing your energy and work in building your immunity to fight with cold, flu and viral infections. The new Supradyn has Methylcobalamin- an active form of Vit B12. The new and improved formulation has higher Zinc to strengthen your immunity",
                    category = "Vitamin",
                    image = "https://www.netmeds.com/images/product-v1/600x600/963415/supradyn_daily_tablet_15s_0_1.jpg"

                },

                new Products
                {
                    id = 3,
                    title = "OurDaily Vitamin E Softgel Capsules 10's",
                    price = 40,
                    description = "The contents of this website are for informational purposes only and not intended to be a substitute for professional medical advice, diagnosis, or treatment. Please seek the advice of a physician or other qualified health provider with any questions you may have regarding a medical condition. Do not disregard professional medical advice or delay in seeking it because of something you have read on this website.",
                    category = "Vitamin",
                    image = "https://www.netmeds.com/images/product-v1/600x600/934750/ourdaily_vitamin_e_softgel_capsules_10s_0_0.jpg"

                }

            };


        [HttpGet]
        public async Task<ActionResult<List<Products>>> Get()
        {   

            return Ok(product_list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> Get(int id)
        {
            var products = product_list.Find(h => h.id == id);
            if (products == null)
                return BadRequest("Product not Found");
            return Ok(products);
        }

        [HttpGet("category/{category}")]
        public async Task<ActionResult<Products>> get(string category)
        {
            var products1 = product_list.FindAll(h => h.category == category);
            if (products1 == null)
               return BadRequest("product not found");
           return Ok(products1);
       }
    }
}
