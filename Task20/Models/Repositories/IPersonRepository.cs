using System.Collections.Generic;
using Task20.Models.Entities;

namespace Task20.Models.Repositories
{
    public interface IPersonRepository
    {
        List<IPerson> People { get; }
    }
}
