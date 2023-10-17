using ShopSolutions.DataAccess;
using ShopSolutions.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolutions.Repository.Implementations
{
    public class ProductRepository:RepositoryBase<Product,ApplicationDbContext>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
