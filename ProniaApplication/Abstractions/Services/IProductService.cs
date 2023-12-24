using Microsoft.AspNetCore.Mvc;
using Pronia.Application.DTOs.Category;
using Pronia.Application.DTOs.Product;
using Pronia.Application.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductItemDto>> GetAllPaginatedAsync(int page, int take);
        Task<ProductGetDto> GetByIsAsync(int id);
        Task CreateAsync(ProductCreateDto productCreateDto);
    }
}
