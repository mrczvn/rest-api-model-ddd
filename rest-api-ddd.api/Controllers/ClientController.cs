﻿using Microsoft.AspNetCore.Mvc;
using rest_api_ddd.application.interfaces;
using System.Collections.Generic;

namespace rest_api_ddd.api.Controllers
{
    [Route("client")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IApplicationServiceClient _applicationServiceClient;

        public ClientController(IApplicationServiceClient ApplicationServiceClient)
        {
            _applicationServiceClient = ApplicationServiceClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClient.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceClient.GetById(id));
        }
    }
}