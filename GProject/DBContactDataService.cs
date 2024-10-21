using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject
{
    public class DBContactDataService : IContactDataService
    {
        List<Person> _contacts;
        public DBContactDataService()
        {
            _contacts = new List<Person>
            {
                new Person("Alice", "Smith"),
                new Person("Bob", "Johnson"),
                new Person("Charlie", "Brown"),
                new Person("David", "Williams"),
                new Person("Eva", "Davis")
            };
        }
        public List<Person> GetContacts()
        {
            return _contacts;
        }
    }
}
