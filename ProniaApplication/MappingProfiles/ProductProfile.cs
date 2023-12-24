using AutoMapper;
using Pronia.Application.DTOs.Product;
using Pronia.Domain.Entities;


namespace Pronia.Application.MappingProfiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductGetDto>().ReverseMap();
            CreateMap<Product, ProductItemDto>().ReverseMap();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}
