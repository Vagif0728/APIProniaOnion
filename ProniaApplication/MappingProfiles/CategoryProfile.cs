using AutoMapper;
using Pronia.Application.DTOs.Category;
using Pronia.Application.DTOs.Categories;
using Pronia.Domain.Entities;

namespace Pronia.Application.MappingProfiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryItemDto>().ReverseMap();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<Category, IncludeCategoryDto>();
        }
    }
}
