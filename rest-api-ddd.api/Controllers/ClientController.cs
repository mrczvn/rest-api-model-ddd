using Microsoft.AspNetCore.Mvc;
using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces;
using System;
using System.Collections.Generic;

namespace rest_api_ddd.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IApplicationServiceClient applicationServiceClient;

        public ClientsController(IApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceClient.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceClient.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Add(clientDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Update(clientDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Remove(clientDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}