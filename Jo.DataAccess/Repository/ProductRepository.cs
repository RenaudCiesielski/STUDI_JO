using Jo.DataAccess.Repository.IRepository;
using Jo.Models;
using JO.DataAccess.Data;
using JO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jo.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        { 
            _db = db;   
        }
        
        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
