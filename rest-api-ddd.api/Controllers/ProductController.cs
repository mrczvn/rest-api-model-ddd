using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rest_api_ddd.application.interfaces;

namespace rest_api_ddd.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct;
        public ProductController(IApplicationServiceProduct ApplicationServiceProduct)
        {
            _applicationServiceProduct = ApplicationServiceProduct;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduct.GetAll());
        }
    }
}
