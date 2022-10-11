using APIFirst.Models;
using APIFirst.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace APIFirst.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        //WrongWay
        //IPersonService service = new PersonService();

        IPersonService service;

        public PeopleController(IPersonService service) { 
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Person> Get() {
            return service.GetAll();
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            service.Add(person);
            return person;
        } 
     }
}
