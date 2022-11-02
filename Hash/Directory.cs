using System;
using System.Collections.Generic;
using System.Linq;

namespace Hash
{
    public class Directory
    {
        private readonly Dictionary<string, List<Contact>> _hashTable;

        public Directory() =>
            _hashTable = new Dictionary<string, List<Contact>>();

        private bool isExists(string name)
        {
            var hash = Hash.Generate(name);

            if (!_hashTable.ContainsKey(hash))
                return false;

            var hashTableItem = _hashTable[hash];

            if (hashTableItem != null)
            {
                var item = hashTableItem.SingleOrDefault(i => i.Name == name);

                if (item != null)
                {
                    return true;
                }
            }

            return false;
        }

        public List<Contact> Get()
        {
            var list = new List<Contact>();

            foreach(var listContact in _hashTable.Values)
                foreach(var contact in listContact)
                    list.Add(contact);
                
            return list;
        }

        public List<Contact> GetByName(string name)
        {
            var hash = Hash.Generate(name);

            var hashTableItem = _hashTable[hash];

            return hashTableItem.Where(i => i.Name == name).ToList();
        }

        public void Add(Contact c)
        {
            if (!Validator.isPhone(c.Phone) || Validator.isEmptyString(c.Name))
            {
                Console.WriteLine("Wrong data!");
                return;
            }

            //Фио считается уникальным, поэтому его повторение запрещается, иначе в случае одинакового хеша и имени невозможно было бы удалить нужную запись
            //Для проверки коллизии можно убрать эту проверку и добавить запись с уже существующим фио, но операции кроме просмотра списка будут недоступны с этой записью
            //Скриншот подтвержающие решении колизии я высылал вместе с проектом
            if (isExists(c.Name))
            {
                Console.WriteLine("The contact already exists");
                return;
            }

            var hash = Hash.Generate(c.Name);

            if (_hashTable.ContainsKey(hash))
            {
                var list = _hashTable[hash];
                list.Add(c);
                return;
            }
            
            _hashTable[hash] = new List<Contact> { c };
        }

        public void Remove(string name)
        {
            if (!isExists(name))
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            var hash = Hash.Generate(name);

            var hashTableItem = _hashTable[hash];

            hashTableItem.Remove(hashTableItem.SingleOrDefault(i => i.Name == name));
        }

        //Полное редактировние при котором запись удаляется и добавляется снова для генерации нового хеша
        public void Update(string name, Contact c)
        {
            if (!isExists(name))
                return;

            Remove(name);
            Add(c);
        }

        //Полноценное редактирование при котором изменяется только номер телефона
        //Хеш и фио остаются нетронутыми
        public void UpdatePhone(string name, string phone)
        {
            if (!isExists(name))
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            if (!Validator.isPhone(phone))
            {
                Console.WriteLine("Wrong phone number");
                return;
            }

            var hash = Hash.Generate(name);

            var hashTableItem = _hashTable[hash];

            hashTableItem.SingleOrDefault(i => i.Name == name).Phone = phone;
        }
    }
}
