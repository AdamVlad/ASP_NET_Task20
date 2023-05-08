namespace Task20.Models.Entities
{
    public interface IPerson
    {
        int Id { get; }

        string Name { get; }

        string LastName { get; }

        string MiddleName { get; }

        string Phone { get; }

        string Email { get; }
    }
}
