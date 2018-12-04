using DatabaseAndTimer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatabaseAndTimer.Controllers
{
    public class APIController : ApiController
    {
        // GET: api/API
        public string Get()
        {
            return PersonModel.GetName();
        }

        // POST: api/API
        public void Post([FromBody]string value)
        {
            PersonModel.SetName(value);
        }

    }
}
