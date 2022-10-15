using System;
using System.Collections.Generic;
using System.Linq;

namespace Hash
{
    public class Directory
    {
        private readonly List<Contact> contacts;

        public Directory() =>
            contacts = new List<Contact>();

        public List<Contact> Get() => 
            contacts.ToList();
        

        public List<Contact> GetByName(string name) => 
            contacts.Where(c => c.Name == Hash.Generate(name)).ToList();
        

        public void Add(Contact c)
        {
            if (!Validator.isPhone(c.Phone) || Validator.isEmptyString(c.Name))
            {
                Console.WriteLine("Wrong data!");
                return;
            }
                
            c.Name = Hash.Generate(c.Name);
            c.Phone = Hash.Generate(c.Phone);
            contacts.Add(c);
        }

        public void Remove(string name)
        {
            string hash = Hash.Generate(name);
            if (!isExists(hash))
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            contacts.Remove(contacts.FirstOrDefault(n => n.Name == hash));
        }

        public void Update(string name, Contact c)
        {
            string hash = Hash.Generate(name);
            if (!isExists(hash))
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            contacts.Remove(contacts.FirstOrDefault(n => n.Name == hash));
            Add(c);
        }

        private bool isExists(string hash)
        {
            if (contacts.Any(n => n.Name == hash))
                return true;
            return false;
        }
    }
}
