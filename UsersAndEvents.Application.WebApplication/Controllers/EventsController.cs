using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UsersAndEvents.Crosscutting.Domain;

namespace UsersAndEvents.Application.WebApplication.Controllers
{
    public class EventsController : ApiController
    {
        // GET: api/Events
        public IEnumerable<Event> Get()
        {
            return new Event[] { new Event { Id=123, Text = "IOLO" } };
        }

        // GET: api/Events/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Events
        public void Post([FromBody]Event value)
        {
        }

        // PUT: api/Events/5
        public void Put(int id, [FromBody]Event value)
        {
        }

        // DELETE: api/Events/5
        public void Delete(int id)
        {
        }
    }
}
