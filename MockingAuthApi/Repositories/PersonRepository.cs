using MockingAuthApi.Models;
using System.Threading.Tasks;

namespace MockingAuthApi.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public Task AddPerson(PersonModel person)
        {
            // add to db
            return Task.CompletedTask;
        }
    }
}
