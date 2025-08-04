using Xunit;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApp.IntegrationTest
{
    public class IntegrationTestPages : IClassFixture<WebApplicationFactory<WebApp253E01.Program>>
    {
        private readonly HttpClient _client;

        public IntegrationTestPages(WebApplicationFactory<WebApp253E01.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Privacy")]
        public async Task TestGetPages(string url)
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
