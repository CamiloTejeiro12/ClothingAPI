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

        Clothes clothes = new Clothes();

        [HttpGet("getAllClothing")]
        public IActionResult GetAllClothing()
        {
            return Ok(clothes.GetAllClothing());
        }

        [HttpGet("getClothing/{id}")]
        public IActionResult GetClothing(int id)
        {
            Clothing clothing = clothes.GetClothing(id);

            if (clothing == null)
            {
                return NotFound();
            }

            return Ok(clothing);
        }

        [HttpPost("newClothing")]
        public IActionResult NewClothing([FromBody] Clothing clothing)
        {
            if (!clothes.AddClothing(clothing))
            {
                return BadRequest();
            }

            return Ok(clothing);
        }

        [HttpPut("updateClothing/{id}")]
        public IActionResult UpdateClothing(int id, [FromBody] Clothing clothing)
        {
            if (!clothes.UpdateClothing(id, clothing))
            {
                return NotFound();
            }

            return Ok(clothing);
        }

        [HttpDelete("removeClothing/{id}")]
        public IActionResult RemoveClothing(int id)
        {
            if (!clothes.RemoveClothing(id))
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
