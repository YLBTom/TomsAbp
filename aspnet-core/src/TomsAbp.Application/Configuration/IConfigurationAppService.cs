using System.Threading.Tasks;
using TomsAbp.Configuration.Dto;

namespace TomsAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
