using MockingAuthApi.Models;
using System.Threading.Tasks;

namespace MockingAuthApi.Repositories
{
    public interface IPersonRepository
    {
        Task AddPerson(PersonModel person);
    }
}
