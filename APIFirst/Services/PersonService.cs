using System.Collections.Generic;
using APIFirst.Models;

namespace APIFirst.Services
{
    public class PersonService : IPersonService
    {
        List<Person> _persons = new List<Person>()
        {
            new Person(){ Sno=1,Name="Ravi",City="Chennai"},
            new Person(){ Sno=2,Name="Roger",City="Mumbai"},
            new Person(){ Sno=3,Name="Harry",City="Bangalore"}
        };

        public void Add(Person x)
        {
            _persons.Add(x);
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }
    }
}
