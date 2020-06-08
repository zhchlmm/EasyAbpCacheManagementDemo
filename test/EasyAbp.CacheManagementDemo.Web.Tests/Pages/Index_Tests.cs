using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace EasyAbp.CacheManagementDemo.Pages
{
    public class Index_Tests : CacheManagementDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
