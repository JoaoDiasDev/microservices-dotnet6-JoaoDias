using Microsoft.AspNetCore.Mvc;
using ShopJoaoDias.CouponAPI.Data.ValueObjects;
using ShopJoaoDias.CouponAPI.Repository;

namespace ShopJoaoDias.CouponAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICouponRepository _repository;

        public CouponController(ICouponRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet("{couponCode}")]
        public async Task<ActionResult<CouponVO>> GetCouponByCouponCode(string couponCode)
        {
            var coupon = await _repository.GetCouponByCouponCode(couponCode);
            if (coupon == null) return NotFound();
            return Ok(coupon);
        }
    }
}
