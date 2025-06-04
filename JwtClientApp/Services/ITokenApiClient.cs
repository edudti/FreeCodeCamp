using System.Threading.Tasks;

namespace JwtClientApp.Services
{
    public interface ITokenApiClient
    {
        Task<string> RequestTokenAsync(string username);
    }
}
