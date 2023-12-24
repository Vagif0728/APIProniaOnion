using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pronia.Application.DTOs.Product;
using Pronia.Application.Abstractions.Repositories;
using Pronia.Application.Abstractions.Services;
using Pronia.Application.DTOs.Product;
using Pronia.Domain.Entities;

namespace Pronia.Persistence.Implementations.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<ProductItemDto>> GetAllPaginatedAsync(int page, int take)
        {
            IEnumerable<ProductItemDto> dtos = _mapper.Map<IEnumerable<ProductItemDto>>(
                await _repository.GetAllWhere(skip: (page - 1) * take, take: take, IsTracking: false).ToArrayAsync()
                );
            return dtos;
        }
        public async Task<ProductGetDto> GetByIsAsync(int id)
        {
            Product product = await _repository.GetByIdAsync(id, includes: nameof(Product.Category));
            ProductGetDto dto = _mapper.Map<ProductGetDto>(product);
            return dto;
        }
        public async Task CreateAsync(ProductCreateDto productCreateDto)
        {
            var product = _mapper.Map<Product>(productCreateDto);

            bool result = await _repository.IsExistAsync(p => p.Name == product.Name);
            if (result) throw new Exception("Bu mehsuldan artiq var");

            result = await _categoryRepository.IsExistAsync(c => c.Id == product.CategoryId);
            if (!result) throw new Exception("Bu  category movcuddur");

            await _repository.AddAsync(product);

            await _repository.SaveChangesAsync();
        }
    }
}
