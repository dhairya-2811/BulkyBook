using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
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
            var objFromDb = _db.Products.FirstOrDefault(u=>u.Id==obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title=obj.Title;
                objFromDb.ISBN=obj.ISBN;
                objFromDb.Price=obj.Price;
                objFromDb.Pric50=obj.Pric50;
                objFromDb.ListPrice=obj.ListPrice;
                objFromDb.Pric100=obj.Pric100;
                objFromDb.Description=obj.Description;
                objFromDb.CategoryId=obj.CategoryId;
                objFromDb.Author=obj.Author;
                objFromDb.CoverTypeId=obj.CoverTypeId;
                if(obj.ImageUrl!=null)
                {
                    obj.ImageUrl=obj.ImageUrl;
                }    
            }
        }
    }
}
