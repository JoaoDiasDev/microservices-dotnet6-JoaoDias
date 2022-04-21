using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopJoaoDias.ProductAPI.Data.ValueObjects;
using ShopJoaoDias.ProductAPI.Repository;
using ShopJoaoDias.ProductAPI.Utils;

namespace ShopJoaoDias.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [Authorize]
        [HttpGet("{id:long}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
            {

            }
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ProductVO>> FindById([FromBody] ProductVO productVo)
        {
            if (productVo == null) return BadRequest();
            var product = await _repository.Create(productVo);
            return Ok(product);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update([FromBody] ProductVO productVo)
        {
            if (productVo == null) return BadRequest();
            var product = await _repository.Update(productVo);
            return Ok(product);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpDelete("{id:long}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
