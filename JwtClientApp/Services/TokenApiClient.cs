using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace JwtClientApp.Services
{
    public class TokenApiClient : ITokenApiClient
    {
        private readonly HttpClient _httpClient;

        public TokenApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> RequestTokenAsync(string username)
        {
            var response = await _httpClient.PostAsJsonAsync("/token", new { username });
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
