using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreApiProject.Models;

namespace CoreApiProject.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public ProductApiController() { }

        [NonAction]
        public List<Product> GetallProduct() {

            List<Product> lst = new List<Product>();
            lst.Add(new Product() { ProductID = 1, ProductName = "Mobile" });
            lst.Add(new Product() { ProductID = 2, ProductName = "Laptop" });
            lst.Add(new Product() { ProductID = 3, ProductName = "Desktop" });
            lst.Add(new Product() { ProductID = 4, ProductName = "TV" });
            lst.Add(new Product() { ProductID = 5, ProductName = "Freez" });
            lst.Add(new Product() { ProductID = 6, ProductName = "Pen" });
            lst.Add(new Product() { ProductID = 7, ProductName = "Pencil" });
            return lst;
         
        }
        [HttpGet]
        [Route("api/product")]
        public List<Product> GetProducts()
        {
            return GetallProduct();
        } 
        [HttpGet]
        [Route("api/product/{id}")]
        public Product GetProducts(int id)
        {
            return GetallProduct().FirstOrDefault(e=>e.ProductID.Equals(id));
        } 
        
    }
    
}
