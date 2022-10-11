using System.Collections.Generic;
using System.Security.Policy;
using APIFirst.Models;

namespace APIFirst.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
        void Add(Person person);
    }
}
