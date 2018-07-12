using System.Collections.Generic;
using AutoMapper;
using Share;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Route("api/TicketDTO")]
    public class TicketController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        private readonly IMapper _mapper;

        // Assign the object in the constructor for dependency injection
        public TicketController(IMapper mapper)
        {
            _mapper = mapper;
        }

        //private IUnitOfWork unitOfWork = new UnitOfWork();
        //public TicketController(IUnitOfWork unitOfWork)
        //{

        //    this.unitOfWork = unitOfWork;
        //}

        // GET: api/TicketDTO
        [HttpGet]
        public IEnumerable<TicketDTO> Get(){

            var model = _mapper.Map<DAL.Models.Ticket, Share.TicketDTO>(new DAL.Models.Ticket());
            model.
            var xx = unitOfWork.TicketRepository.Get();
            return xx;
           // return new string[] { "value1", "value2" };
            
        }

        // GET: api/TicketDTO/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/TicketDTO
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/TicketDTO/5
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
