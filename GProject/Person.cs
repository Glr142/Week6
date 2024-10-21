using System.Security.Cryptography.X509Certificates;

namespace GProject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

    }
}