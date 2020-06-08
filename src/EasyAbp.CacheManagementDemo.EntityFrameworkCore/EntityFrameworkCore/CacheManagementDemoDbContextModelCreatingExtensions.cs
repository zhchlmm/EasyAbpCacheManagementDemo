using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace EasyAbp.CacheManagementDemo.EntityFrameworkCore
{
    public static class CacheManagementDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureCacheManagementDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CacheManagementDemoConsts.DbTablePrefix + "YourEntities", CacheManagementDemoConsts.DbSchema);

            //    //...
            //});
        }
    }
}