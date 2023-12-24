using Pronia.Application.DTOs.Categories;

namespace Pronia.Application.DTOs.Product
{
    public record ProductGetDto(int Id, string Name, decimal Price, string SKU, string? Description, int CategoryId, IncludeCategoryDto Category);
}
