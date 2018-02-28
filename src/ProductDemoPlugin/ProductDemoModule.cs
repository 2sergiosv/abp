using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YkAbp.Core;

namespace ProductDemoPlugin
{
    [DependsOn(
        typeof(YkAbpCoreModule))]
    public class ProductDemoModule: AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ProductDemoModule).Assembly, 
                    moduleName: "ProductDemo", 
                    useConventionalHttpVerbs: true);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProductDemoModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
        }
    }
}
