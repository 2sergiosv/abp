using System.Threading.Tasks;
using Abp.Dependency;

namespace YkAbp.Core.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}