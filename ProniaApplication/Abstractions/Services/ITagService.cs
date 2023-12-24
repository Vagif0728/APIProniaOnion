using Pronia.Application.DTOs.Tag;
using Pronia.Application.DTOs.Tags;

namespace Pronia.Application.Abstractions.Services
{
    public interface ITagService
    {
        Task<ICollection<ColorItemDto>> GetAllAsync(int page, int take);
        Task<ColorGetDto> GetAsync(int id);
        Task CreateAsync(ColorCreateDto tagDto);
        Task UpdateAsync(int id, ColorUpdateDto tagDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
