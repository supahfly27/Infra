using Infra.MongoDB.Entities;
using Infra.MongoDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.MongoDB.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoContext context) : base(context)
        {
        }
    }
}
