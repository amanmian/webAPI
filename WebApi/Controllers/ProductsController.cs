using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        
        context.Products.AddOrUpdate(p => p.ProductId,
                new Product { Name = "Product 1", Category = "Category 1", Price = 200 },
                new Product { Name = "Product 2", Category = "Category 2", Price = 500 },
                new Product { Name = "Product 3", Category = "Category 3", Price = 700 }
                );

        context.Reviews.AddOrUpdate(r => r.ReviewId,
                new Review {Title = "Review 1", Description = "Test review 1", ProductId = 1},
                new Review {Title = "Review 2", Description = "Test review 2", ProductId = 1}
                );
    }
}
