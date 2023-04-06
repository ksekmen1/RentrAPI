using Microsoft.AspNetCore.Cors;
using RentrAPI.Repository;
using RentrAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentrAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentrItemController : Controller
    {
        public readonly RentrItemRepository _RentrItemRepository;

        public RentrItemController(RentrItemRepository rentrItemRepository)
        {
            _RentrItemRepository = rentrItemRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<RentrItem>> Get([FromQuery] string Name = null)
        {
            IEnumerable<RentrItem> item = _RentrItemRepository.GetAll(Name);
            return Ok(item);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<RentrItem> Post([FromBody] RentrItem item)
        {
            try
            {
                RentrItem createdItem = _RentrItemRepository!.Add(item);
                return Created($"/{createdItem.Id}", createdItem);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }

        }





    }
}
