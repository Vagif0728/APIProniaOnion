using AutoMapper;
using Pronia.Application.DTOs.Tag;
using Pronia.Domain.Entities;

namespace Pronia.Application.MappingProfiles
{
    public class TagProfile:Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, ColorItemDto>();
            CreateMap<ColorCreateDto, Tag>();
        }
    }
}
