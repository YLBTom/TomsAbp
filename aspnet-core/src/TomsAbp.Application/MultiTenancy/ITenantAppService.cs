using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TomsAbp.MultiTenancy.Dto;

namespace TomsAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

