using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CoreApiTestProject
{
    public class UnitTest1:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        public UnitTest1()
        {
            _factory = new WebApplicationFactory<Program>();
        }

        [Fact(Skip ="Skip for now")]
        public async Task Test1()
        {
            var client=_factory.CreateClient();
            var response = await client.GetAsync("/api/product");
            int code=(int)response.StatusCode;
            Assert.Equal(200, code);

        }
        [Theory]
        [InlineData("/api/product")]
        public async Task testapi(string url)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);
            int code = (int)response.StatusCode;
            Assert.Equal(200, code);

        }
    }
}