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
    internal class TagRepository:Repository<Tag>,ITagRepository
    {
        public TagRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
