using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using MockingAuthApi.Models;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace MockingAuthApi.Tests
{
    public class When_Calling_PeopleController_Post
    {
        [Fact]
        public async Task Then_Returns_BadRequest_When_ModelState_Invalid()
        {
            var builder = new WebHostBuilder().UseStartup<TestStartup>();
            var testServer = new TestServer(builder);
            var client = testServer.CreateClient();

            var result = await client.PostAsJsonAsync("/api/people", new PersonModel());

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
        }
    }
}
