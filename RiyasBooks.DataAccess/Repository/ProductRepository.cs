using RiyasBooks.DataAccess.Repository.IRepository;
using RiyasBooks.Models;
using RiyasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RiyasBooks.DataAccess.Repository
{
   public class ProductRepository : Repository<ProductRepository>, IProductRepository
    {

        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Product GetFirstOrDefault(Expression<Func<Product, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {

            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
                if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
                //throw new NotImplementedException();
            }
        }

        Product IRepository<Product>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
