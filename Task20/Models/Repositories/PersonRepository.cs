using System.Collections.Generic;
using Task20.Models.Entities;

namespace Task20.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public PersonRepository()
        {
            Load();
        }

        public List<IPerson> People => _people;

        private void Load()
        {
            _people = new List<IPerson>();

            var person1 = new Person(1, "Иван", "Иванов", "Иванович", "8-999-999-99-99", "Ivan@gmail.com");
            var person2 = new Person(2, "Иван2", "Иванов2", "Иванович2", "8-999-999-99-99", "Ivan@gmail.com");
            var person3 = new Person(3, "Иван3", "Иванов3", "Иванович3", "8-999-999-99-99", "Ivan@gmail.com");
            var person4 = new Person(4, "Иван4", "Иванов4", "Иванович4", "8-999-999-99-99", "Ivan@gmail.com");
            var person5 = new Person(5, "Иван5", "Иванов5", "Иванович5", "8-999-999-99-99", "Ivan@gmail.com");
            var person6 = new Person(6, "Иван6", "Иванов6", "Иванович6", "8-999-999-99-99", "Ivan@gmail.com");

            _people.Add(person1);
            _people.Add(person2);
            _people.Add(person3);
            _people.Add(person4);
            _people.Add(person5);
            _people.Add(person6);
        }

        private List<IPerson> _people;
    }
}
