using ShopJoaoDias.CouponAPI.Data.ValueObjects;

namespace ShopJoaoDias.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string couponCode);
    }
}
