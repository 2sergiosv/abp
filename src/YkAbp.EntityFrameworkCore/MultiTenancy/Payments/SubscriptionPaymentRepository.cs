using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using YkAbp.Core.MultiTenancy.Payments;
using YkAbp.EntityFrameworkCore;
using YkAbp.EntityFrameworkCore.Repositories;

namespace YkAbp.EntityFrameworkCore.MultiTenancy.Payments
{
    public class SubscriptionPaymentRepository : YkAbpRepositoryBase<SubscriptionPayment, long>, ISubscriptionPaymentRepository
    {
        public SubscriptionPaymentRepository(IDbContextProvider<YkAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<SubscriptionPayment> UpdateByGatewayAndPaymentIdAsync(ESubscriptionPaymentGatewayType gateway, string paymentId, int? tenantId, SubscriptionPaymentStatus status)
        {
            var payment = await SingleAsync(p => p.PaymentId == paymentId && p.Gateway == gateway);

            payment.Status = status;

            if (tenantId.HasValue)
            {
                payment.TenantId = tenantId.Value;
            }

            return payment;
        }

        public async Task<SubscriptionPayment> GetByGatewayAndPaymentIdAsync(ESubscriptionPaymentGatewayType gateway, string paymentId)
        {
            return await SingleAsync(p => p.PaymentId == paymentId && p.Gateway == gateway);
        }
    }
}
