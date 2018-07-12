﻿using System.Collections.Generic;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //   [Route("api/PlaneTypeDTO")]
    public class PlaneTypeController : Controller
    {
        private IUnitOfWork unitOfWork;
        public PlaneTypeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: api/PlaneTypeDTO
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PlaneTypeDTO/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/PlaneTypeDTO
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/PlaneTypeDTO/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
