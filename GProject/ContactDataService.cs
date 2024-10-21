namespace GProject
{
    public class ContactDataService
    {
        public List<Person> GetContacts()
        {
            return new List<Person>
            {
                new Person("Alice", "Smith"),
                new Person("Bob", "Johnson"),
                new Person("Charlie", "Brown"),
            };
        }
    }
}