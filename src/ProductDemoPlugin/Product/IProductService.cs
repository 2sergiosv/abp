using Abp.Application.Services;
using ProductDemoPlugin.Product.Dto;
using YkAbp.Core.EntityDemo;

namespace ProductDemoPlugin.Product
{
    public interface IProductService: IAsyncCrudAppService<ProductSummaryDto, int, ProductGetAllDto, ProductCreateDto>
    {
    }
}