using Microsoft.EntityFrameworkCore;
using ShopJoaoDias.CouponAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopJoaoDias.CouponAPI.Model
{
    [Table("coupon")]
    public class Coupon : BaseEntity
    {
        [Column("coupon_code")]
        [Required]
        [StringLength(30)]
        public string CouponCode { get; set; }

        [Column("discount_amount")]
        [Required]
        [Precision(18, 2)]
        public decimal DiscountAmount { get; set; }
    }
}
