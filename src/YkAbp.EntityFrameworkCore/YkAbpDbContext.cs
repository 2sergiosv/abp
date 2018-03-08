using System.IO;
using System.Linq;
using System.Reflection;
using Abp.Domain.Repositories;
using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.Chat;
using YkAbp.Core.Editions;
using YkAbp.Core.EntityDemo;
using YkAbp.Core.Friendships;
using YkAbp.Core.MultiTenancy;
using YkAbp.Core.MultiTenancy.Accounting;
using YkAbp.Core.MultiTenancy.Payments;
using YkAbp.Core.Storage;
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
        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        // TODO: Define an IDbSet for each entity of the application 
        public virtual DbSet<ProductDemo> ProductDemos { get; set; }

        public YkAbpDbContext(DbContextOptions<YkAbpDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { e.PaymentId, e.Gateway });
            });

            modelBuilder.ConfigurePersistedGrantEntity();

            // ApplyEntitiesFromPlugins(modelBuilder);

            // TODO: configure the model here
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
