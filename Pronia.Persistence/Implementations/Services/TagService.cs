using Microsoft.EntityFrameworkCore;
using Pronia.Application.DTOs.Category;
using Pronia.Application.DTOs.Tag;
using Pronia.Application.Abstractions.Repositories;
using Pronia.Application.Abstractions.Services;
using Pronia.Application.DTOs.Categories;
using Pronia.Application.DTOs.Tags;
using Pronia.Domain.Entities;

namespace Pronia.Persistence.Implementations.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _repository;

        public TagService(ITagRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(ColorCreateDto tagCreateDto)
        {
            Tag tag = new Tag
            {
                Name = tagCreateDto.Name
            };
            await _repository.AddAsync(tag);
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<ColorItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Tag> tags = await _repository.GetAllWhere(skip: (page - 1) * take, take: take, IsTracking: false, isDeleted: true).ToListAsync();

            ICollection<ColorItemDto> tagItemDtos = new List<ColorItemDto>();

            foreach (Tag tag in tags)
            {
                tagItemDtos.Add(new ColorItemDto(tag.Id, tag.Name));
            }
            return tagItemDtos;
        }
        public async Task UpdateAsync(int id, ColorUpdateDto tagUpdateDto)
        {
            Tag tag = await _repository.GetByIdAsync(id);

            if (tag is null) throw new Exception("Not found");

            tag.Name = tagUpdateDto.Name;

            _repository.Update(tag);
            await _repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);

            if (tag is null) throw new Exception("Not found");

            _repository.Delete(tag);
            await _repository.SaveChangesAsync();
        }
        public async Task SoftDeleteAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);
            if (tag is null) throw new Exception("Not found");
            _repository.SoftDelete(tag);
            await _repository.SaveChangesAsync();
        }

        public async Task<ColorGetDto> GetAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);
            if (tag is null) throw new Exception("Not found");
            return new ColorGetDto(tag.Id, tag.Name);
        }
    }
}
