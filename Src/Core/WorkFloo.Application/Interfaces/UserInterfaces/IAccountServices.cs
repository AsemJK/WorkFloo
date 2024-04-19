using System.Threading.Tasks;
using WorkFloo.Application.DTOs.Account.Requests;
using WorkFloo.Application.DTOs.Account.Responses;
using WorkFloo.Application.Wrappers;

namespace WorkFloo.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
