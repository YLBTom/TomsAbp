using System.Threading.Tasks;
using Abp.Application.Services;
using TomsAbp.Sessions.Dto;

namespace TomsAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
