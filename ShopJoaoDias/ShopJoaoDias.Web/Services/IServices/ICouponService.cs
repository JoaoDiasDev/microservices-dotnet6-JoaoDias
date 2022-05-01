using ShopJoaoDias.Web.Models;
using System.Threading.Tasks;

namespace ShopJoaoDias.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetCoupon(string code, string token);
    }
}
