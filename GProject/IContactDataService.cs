using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject
{
    public interface IContactDataService
    {
        List<Person> GetContacts();
    }
}
