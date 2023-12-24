using Pronia.Application.DTOs.Category;
using Pronia.Application.DTOs.Categories;

namespace Pronia.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryItemDto>> GetAllAsync(int page, int take);
        Task<CategoryGetDto> GetAsync(int id);
        Task CreateAsync(CategoryCreateDto categoryDto);
        Task UpdateAsync(int id, CategoryUpdateDto categoryDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
