using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SampleBarterApp.Roles.Dto;
using SampleBarterApp.Users.Dto;

namespace SampleBarterApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}