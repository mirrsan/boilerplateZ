using System.Threading.Tasks;
using BoilerplateZadatak.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerplateZadatak.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerplateZadatakWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
