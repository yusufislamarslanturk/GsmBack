using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Login(LoginDTO loginDTO);
        IDataResult<User> Register(RegisterDTO registerDTO);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult UpdatePassword(UpdatePasswordDTO updatePasswordDTO);
    }
}
