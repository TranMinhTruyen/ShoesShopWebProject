using ShoesShopWebApp.Common.Req;
using ShoesShopWebApp.DAL.Model;
using ShoesShopWebApp.DAL.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoesShopWebApp.BLL.Svc
{
    public class ProductSvc
    {
        private readonly ProductRep productRep;
        public ProductSvc()
        {
            productRep = new ProductRep();
        }


        public object CreateProduct(ProductReq req)
        {
            Product product = new Product();
            product.ProductID = req.ProductID;
            product.ProductName = req.ProductName;
            product.Price = req.Price;
            product.BrandID = req.BrandID;
            product.CategoryID = req.CategoryID;
            product.CreateDate = req.CreateDate;
            product.Unit = req.Unit;
            product.UnitsInStock = req.UnitsInStock;
            product.Discount = req.Discount;
            product.Description = req.Description;
            product.Picture = req.Picture;
            product.Description = req.Note;
            return productRep.Create(product);
        }


        public object UpdateProduct(String id, ProductReq req)
        {
            return productRep.Update(id ,req);
        }


        public object SearchProduct(int size, int page, String keyword)
        {
            var allValues = productRep.All;
            if (!string.IsNullOrEmpty(keyword))
            {
                allValues = productRep.All.Where(value => value.ProductID.Contains(keyword) || value.ProductName.Contains(keyword));
            }
            int offset = (page - 1) * size;
            int total = allValues.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = allValues.Skip(offset).Take(size).ToList();
            var result = new
            {
                Data = data,
                totalRecord = total,
                Page = page,
                Size = size,
                TotalPage = totalPage
            };
            return result;
        }


        public object DeleteProduct(String id)
        {
            return productRep.Delete(id);
        }
    }
}
