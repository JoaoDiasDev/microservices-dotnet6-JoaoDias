using Microsoft.AspNetCore.Mvc;
using ShopJoaoDias.CartAPI.Data.ValueObjects;
using ShopJoaoDias.CartAPI.Messages;
using ShopJoaoDias.CartAPI.RabbitMqSender;
using ShopJoaoDias.CartAPI.Repository;
using System;
using System.Threading.Tasks;

namespace ShopJoaoDias.CartAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController : ControllerBase
    {
        private ICartRepository _repository;
        private IRabbitMqMessageSender _rabbitMqMessageSender;

        public CartController(ICartRepository repository, IRabbitMqMessageSender rabbitMqMessageSender)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
            _rabbitMqMessageSender = rabbitMqMessageSender ?? throw new ArgumentNullException(nameof(rabbitMqMessageSender));
        }

        [HttpGet("find-cart/{id}")]
        public async Task<ActionResult<CartVO>> FindById(string id)
        {
            var cart = await _repository.FindCartByUserId(id);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPost("add-cart")]
        public async Task<ActionResult<CartVO>> AddCart(CartVO vo)
        {
            var cart = await _repository.SaveOrUpdateCart(vo);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPut("update-cart")]
        public async Task<ActionResult<CartVO>> UpdateCart(CartVO vo)
        {
            var cart = await _repository.SaveOrUpdateCart(vo);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpDelete("remove-cart/{id}")]
        public async Task<ActionResult<CartVO>> RemoveCart(int id)
        {
            var status = await _repository.RemoveFromCart(id);
            if (!status) return BadRequest();
            return Ok(status);
        }

        [HttpPost("apply-coupon")]
        public async Task<ActionResult<CartVO>> ApplyCoupon(CartVO vo)
        {
            var status = await _repository.ApplyCoupon(vo.CartHeader.UserId, vo.CartHeader.CouponCode);
            if (!status) return NotFound();
            return Ok(status);
        }

        [HttpDelete("remove-coupon/{userId}")]
        public async Task<ActionResult<CartVO>> RemoveCoupon(string userId)
        {
            var status = await _repository.RemoveCoupon(userId);
            if (!status) return NotFound();
            return Ok(status);
        }

        [HttpPost("checkout")]
        public async Task<ActionResult<CheckoutHeaderVO>> Checkout(CheckoutHeaderVO vo)
        {
            if (vo?.UserId == null) return BadRequest();
            var cart = await _repository.FindCartByUserId(vo.UserId);
            if (cart == null) return NotFound();
            vo.CartDetails = cart.CartDetails;
            vo.DateTime = DateTime.Now;

            _rabbitMqMessageSender.SendMessage(vo, "checkout_queue");

            return Ok(vo);
        }
    }
}