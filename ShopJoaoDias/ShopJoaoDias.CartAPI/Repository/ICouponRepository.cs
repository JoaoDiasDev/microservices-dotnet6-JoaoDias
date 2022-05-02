using ShopJoaoDias.CartAPI.Data.ValueObjects;
using System.Threading.Tasks;

namespace ShopJoaoDias.CartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCoupon(string couponCode, string token);
    }
}
