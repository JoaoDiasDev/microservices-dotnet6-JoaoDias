using System.Collections.Generic;
using System.Threading.Tasks;
using ShopJoaoDias.ProductAPI.Data.ValueObjects;

namespace ShopJoaoDias.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO vo);
        Task<ProductVO> Update(ProductVO vo);
        Task<bool> Delete(long id);
    }
}
