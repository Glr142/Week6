﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject
{
    public class ContactFinder
    {
        private IContactDataService _dataService;
        public ContactFinder(IContactDataService dataService)
        {
            _dataService = new ContactDataService();
        }
        public List<Person> GetContactsBy(string name)
        {
            List<Person> contacts = _dataService.GetContacts();
            for (int i = contacts.Count - 1; i>=0; i--)
            {
                if (!contacts[i].FirstName.Contains(name))
                {
                   contacts.RemoveAt(i);
                }
            }
            return contacts;
        }
    }
}