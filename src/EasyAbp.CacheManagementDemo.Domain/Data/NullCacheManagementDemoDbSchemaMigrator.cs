using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.CacheManagementDemo.Data
{
    /* This is used if database provider does't define
     * ICacheManagementDemoDbSchemaMigrator implementation.
     */
    public class NullCacheManagementDemoDbSchemaMigrator : ICacheManagementDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}