using BookWeb.DataAccess.Repository.IRepository;
using BookWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.DataAccess.Repository
{
    public class ProductReposutory : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductReposutory(ApplicationDbContext context): base(context)
        {
            _context = context;
        }

        public void Update(Product obj)
        {
            var objFromDb = _context.Products.FirstOrDefault(u => u.Id == obj.Id);
            
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Author = obj.Author;
                objFromDb.CoverTypeID = obj.CoverTypeID;

                if(objFromDb.ImageURL != null) 
                    objFromDb.ImageURL = obj.ImageURL;
            }
        }
    }
}
