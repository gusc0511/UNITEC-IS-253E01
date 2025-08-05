using Xunit;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;


namespace WebApp.IntegrationTest
{
    public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public IntegrationTestPages(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("/index")]
        [InlineData("/Privacy")]
        [InlineData("/About")]
        [InlineData("/Contact")]
        [InlineData("/Faq")]
        public async Task TestGetPages(string url)
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}