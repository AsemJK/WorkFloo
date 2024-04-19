using System.Threading.Tasks;
using WorkFloo.Application.DTOs.Account.Requests;
using WorkFloo.Application.DTOs.Account.Responses;
using WorkFloo.Application.Wrappers;

namespace WorkFloo.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
