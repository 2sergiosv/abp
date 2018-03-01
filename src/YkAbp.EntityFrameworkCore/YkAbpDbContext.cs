using System.IO;
using System.Linq;
using System.Reflection;
using Abp.Domain.Repositories;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.EntityDemo;
using YkAbp.Core.MultiTenancy;
using YkAbp.Core.Web;
using YkAbp.EntityFrameworkCore.Repositories;

namespace YkAbp.EntityFrameworkCore
{
    [AutoRepositoryTypes(
        typeof(IRepository<>),
        typeof(IRepository<,>),
        typeof(YkAbpRepositoryBase<>),
        typeof(YkAbpRepositoryBase<,>)
    )]
    public class YkAbpDbContext : AbpZeroDbContext<Tenant, Role, User, YkAbpDbContext>
    {
        // TODO: Define an IDbSet for each entity of the application 
        public virtual DbSet<ProductDemo> ProductDemos { get; set; }

        public YkAbpDbContext(DbContextOptions<YkAbpDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyEntitiesFromPlugins(modelBuilder);

            // TODO: configure the model here

            base.OnModelCreating(modelBuilder);
        }

        // 见：http://10.0.200.18/abp/ykabp/issues/1
        protected virtual void ApplyEntitiesFromPlugins(ModelBuilder modelBuilder)
        {
            var pluginsRoot = Path.Combine(WebContentDirectoryFinder.CalculateContentRootFolder(), "Plugins");
            if(!Directory.Exists(pluginsRoot)) return;
            
            // get all Assemblies
            var dllList = Directory.GetFiles(pluginsRoot, "*.dll", SearchOption.AllDirectories);
            var types = dllList.Select(Assembly.LoadFile)
                .SelectMany(x => x.DefinedTypes.Select(t => t.AsType()));
        }
    }
}
