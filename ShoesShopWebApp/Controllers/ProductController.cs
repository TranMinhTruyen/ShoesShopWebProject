using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoesShopWebApp.BLL.Svc;
using ShoesShopWebApp.Common.Req;
using Newtonsoft.Json;

namespace ShoesShopWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductSvc productSvc;
        public ProductController()
        {
            productSvc = new ProductSvc();
        }

        [HttpPost("Create_Product")]
        public IActionResult CreateProduct(ProductReq req)
        {
            var result = productSvc.CreateProduct(req);
            return Ok(result);
        }


        [HttpGet("Search_Product/{size},{page}")]
        public IActionResult SearchProduct(int size, int page, String keyword)
        {
            var result = productSvc.SearchProduct(size, page, keyword);
            return Ok(result);
        }


        [HttpPut("Update_Product/{id}")]
        public IActionResult UpdateProduct(String id, ProductReq req)
        {
            var result = productSvc.UpdateProduct(id, req);
            return Ok(result);
        }


        [HttpDelete("Delete_Product/{id}")]
        public IActionResult DeleteProduct(String id)
        {
            var result = productSvc.DeleteProduct(id);
            return Ok(result);
        }
    }
}
