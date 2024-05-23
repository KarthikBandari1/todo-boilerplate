using System.Threading.Tasks;
using Abp.Application.Services;
using todo3.Sessions.Dto;

namespace todo3.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
