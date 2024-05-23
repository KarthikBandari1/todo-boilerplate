using System.Threading.Tasks;
using todo3.Models.TokenAuth;
using todo3.Web.Controllers;
using Shouldly;
using Xunit;

namespace todo3.Web.Tests.Controllers
{
    public class HomeController_Tests: todo3WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}