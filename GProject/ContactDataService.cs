﻿namespace GProject
{
    public class ContactDataService : IContactDataService
    {
        List<Person> _contacts;
        public ContactDataService()
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