using Microsoft.AspNetCore.Mvc;
using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces;
using System;
using System.Collections.Generic;

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

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduct.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationServiceProduct.Add(productDto);
                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationServiceProduct.Update(productDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationServiceProduct.Remove(productDto);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}