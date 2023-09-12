using Shopy.DataAccess.Data;
using Shopy.DataAccess.Repository.IRepository;
using Shopy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopy.DataAccess.Repository
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
            var objFromDb=_db.Products.FirstOrDefault(u=>u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Title = objFromDb.Title;
                objFromDb.ISBN = objFromDb.ISBN;
                objFromDb.Price = objFromDb.Price;
                objFromDb.Price50 = objFromDb.Price50;
                objFromDb.ListPrice = objFromDb.ListPrice;
                objFromDb.Price100 = objFromDb.Price100;
                objFromDb.Description = objFromDb.Description;
                objFromDb.Category = objFromDb.Category;
                objFromDb.Author = objFromDb.Author;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
