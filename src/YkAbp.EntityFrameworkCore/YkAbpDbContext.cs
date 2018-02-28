using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.EntityDemo;
using YkAbp.Core.MultiTenancy;

namespace YkAbp.EntityFrameworkCore
{
    public class YkAbpDbContext : AbpZeroDbContext<Tenant, Role, User, YkAbpDbContext>
    {
        // TODO: Define an IDbSet for each entity of the application 
        public DbSet<ProductDemo> ProductDemos { get; set; }

        public YkAbpDbContext(DbContextOptions<YkAbpDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: configure the model here

        }
    }
}
