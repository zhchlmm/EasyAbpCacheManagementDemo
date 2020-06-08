using System.Threading.Tasks;

namespace EasyAbp.CacheManagementDemo.Data
{
    public interface ICacheManagementDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
