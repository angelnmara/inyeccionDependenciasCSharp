using HomeInc.DTO;
using HomeInc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeInc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> Get() => _service.findAll();

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProductDTO> Create(ProductDTO productDTO)
        {
            ProductDTO productDTO_ = _service.save(productDTO);
            int id = _service.findAll().Count();
            return productDTO_; //CreatedAtAction(nameof(id), new { id = productDTO_.ProductID }, productDTO_);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProductDTO> Update(ProductDTO productDTO)
        {
            return _service.update(productDTO);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProductDTO> Delete(int id)
        {
            return _service.delete(id);
        }
    }
}
