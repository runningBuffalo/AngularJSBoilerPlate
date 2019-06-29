using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    public class IssueController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            List<IssueModel> issues = new List<IssueModel>(){
                new IssueModel() { Id = 5, DateCreated = DateTime.Now, Name = "Foo" },
                new IssueModel() { Id = 3, DateCreated = DateTime.Now, Name = "5G" },
                new IssueModel() { Id = 7, DateCreated = DateTime.Now, Name = "Yay" }
            };
            string jsonString = JsonConvert.SerializeObject(issues);
            HttpResponseMessage message = new HttpResponseMessage();
            message.Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
            return jsonString;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
