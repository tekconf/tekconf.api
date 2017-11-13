using System.Threading.Tasks;

namespace tekconf.api.Infrastructure.Security
{
    public interface IJwtTokenGenerator
    {
        Task<string> CreateToken(string username);
    }
}