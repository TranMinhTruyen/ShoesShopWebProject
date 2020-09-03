using ShoesShopWebApp.Common.Req;
using System;
using System.Collections.Generic;
using System.Text;
using ShoesShopWebApp.DAL.Model;
using System.Linq;

namespace ShoesShopWebApp.DAL.Rep
{
    public class ProductRep
    {
        private Context context;


        public ProductRep()
        {
            context = new Context();
        }


        public object Create(Product product)
        {
            try
            {
                context.Product.Add(product);
                context.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
        }


        public object Update(String id, ProductReq req)
        {
            try
            {
                var result = context.Product.FirstOrDefault(value => value.ProductID == id);
                if (result != null)
                {
                    result.ProductName = req.ProductName;
                    result.Price = req.Price;
                    result.BrandID = req.BrandID;
                    result.CategoryID = req.CategoryID;
                    result.CreateDate = req.CreateDate;
                    result.Unit = req.Unit;
                    result.UnitsInStock = req.UnitsInStock;
                    result.Discount = req.Discount;
                    result.Description = req.Description;
                    result.Picture = req.Picture;
                    result.Description = req.Note;
                    context.Product.Update(result);
                    context.SaveChanges();
                    return result;
                }
                else
                {
                    return "Unable to update: not found ID.";
                }
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
        }


        public object Delete (String id)
        {
            var result = context.Product.FirstOrDefault(value => value.ProductID == id);
            try
            {
                if (result != null)
                {
                    context.Product.Remove(result);
                    context.SaveChanges();
                    return result;
                }
                else
                {
                    return "Unable to delete: not found ID.";
                }
            }
            catch(Exception ex)
            {
                return ex.StackTrace;
            }
        }


        public IQueryable<Product> All
        {
            get
            {
                IQueryable<Product> result = context.Product;
                return result;
            }
        }
    }
}
