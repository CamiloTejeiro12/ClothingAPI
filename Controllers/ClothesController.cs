using ClothingAPI.Models;
using ClothingAPI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingController : ControllerBase
    {

        Clothes clothes;

        public ClothingController()
        {
            clothes = new Clothes();
        }

        [HttpGet("getAllClothing")]
        public IActionResult getAllClothe()
        {

            return Ok(clothes.getAllClothing());
        }


        [HttpGet("getClothing")]
        public IActionResult GetClothing([FromBody]int id) {
            
            Clothing clothe = clothes.getClothe(id);

            if(clothe == null)
            {
                return NotFound();
            }

            return Ok(clothe);
        }

        [HttpPost("newClothing")]
        public IActionResult newClothe([FromBody]Clothing clothe)
        {


            if (!clothes.newClothe(clothe))
            {
                return BadRequest();
            }

            return Ok(clothe);
        }


    }
}
