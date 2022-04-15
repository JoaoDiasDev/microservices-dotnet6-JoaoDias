using AutoMapper;
using ShopJoaoDias.ProductAPI.Data.ValueObjects;
using ShopJoaoDias.ProductAPI.Model;

namespace ShopJoaoDias.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
