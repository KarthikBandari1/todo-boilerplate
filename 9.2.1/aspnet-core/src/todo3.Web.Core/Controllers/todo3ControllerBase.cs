using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace todo3.Controllers
{
    public abstract class todo3ControllerBase: AbpController
    {
        protected todo3ControllerBase()
        {
            LocalizationSourceName = todo3Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
