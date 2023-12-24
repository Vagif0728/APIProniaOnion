using Pronia.Application.Abstractions.Repositories;
using Pronia.Domain.Entities;
using Pronia.Persistence.Contexts;
using Pronia.Persistence.Implementations.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Persistence.Implementations.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }

    }
}
