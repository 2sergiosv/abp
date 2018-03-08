using Abp.Dependency;

namespace YkAbp.Core.MultiTenancy.Payments
{
    public interface IPaymentGatewayManagerFactory
    {
        IDisposableDependencyObjectWrapper<IPaymentGatewayManager> Create(ESubscriptionPaymentGatewayType gateway);
    }
}