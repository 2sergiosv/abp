using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using ProductDemoPlugin.Product.Dto;
using YkAbp.Core.EntityDemo;

namespace ProductDemoPlugin.Product
{
    [AbpAuthorize]
    public class ProductService: AsyncCrudAppService<ProductDemo, ProductSummaryDto, int, ProductGetAllDto, ProductCreateDto>, IProductService
    {
        public ProductService(IRepository<ProductDemo> repository)
            : base(repository)
        {
        }
    }
}