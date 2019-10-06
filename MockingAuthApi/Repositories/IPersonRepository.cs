using MockingAuthApi.Models;
using System.Threading.Tasks;

namespace MockingAuthApi.Repositories
{
    protected interface IPersonRepository
    {
        Task AddPerson(PersonModel person);
    }
}
