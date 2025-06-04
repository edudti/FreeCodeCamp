namespace MinimalJwtApi.Services
{
    public interface ITokenService
    {
        string GenerateToken(string username);
    }
}
