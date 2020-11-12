using System.Threading.Tasks;
using ZwajApp.API.Models;

namespace ZwajApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register ( User user , string Password);
         Task<User> Login ( string username , string Password);
         Task<bool> UserExists ( string Username);
    }
}