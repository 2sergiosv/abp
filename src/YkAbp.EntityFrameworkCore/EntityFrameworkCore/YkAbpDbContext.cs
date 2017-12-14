using System;
using Abp.Notifications;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using YkAbp.Authorization.Roles;
using YkAbp.Authorization.Users;
using YkAbp.MultiTenancy;

namespace YkAbp.EntityFrameworkCore
{
    public class YkAbpDbContext : AbpZeroDbContext<Tenant, Role, User, YkAbpDbContext>
    {
        // TODO: Define an IDbSet for each entity of the application 
        
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
