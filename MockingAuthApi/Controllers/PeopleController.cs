namespace MockingAuthApi.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Models;
    using Repositories;

    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private IPersonRepository _personRepository;

        public PeopleController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PersonModel personModel)
        {
            try
            {
                if (!ModelState.IsValid) return this.BadRequest();

                await _personRepository.AddPerson(personModel);
                return this.Ok();
            }
            catch
            {
                return this.BadRequest();
            }
        }
    }
}
