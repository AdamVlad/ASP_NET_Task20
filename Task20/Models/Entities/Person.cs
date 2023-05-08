namespace Task20.Models.Entities
{
    public class Person : IPerson
    {
        public Person(
            int id,
            string name,
            string lastName,
            string middleName,
            string phone,
            string email)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            MiddleName = middleName;
            Phone = phone;
            Email = email;
        }

        public int Id { get; }
        public string Name { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public string Phone { get; }
        public string Email { get; }
    }
}
