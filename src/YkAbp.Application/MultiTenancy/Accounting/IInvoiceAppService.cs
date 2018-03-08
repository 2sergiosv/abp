using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using YkAbp.Application.MultiTenancy.Accounting.Dto;

namespace YkAbp.Application.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
