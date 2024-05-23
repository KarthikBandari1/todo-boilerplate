using System.Threading.Tasks;
using todo3.Configuration.Dto;

namespace todo3.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
