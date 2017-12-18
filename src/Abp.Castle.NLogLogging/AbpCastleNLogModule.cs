using System;
using Abp.Dependency;
using Abp.Modules;
using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using NLog.Config;

namespace Abp.Castle.NLogLogging
{
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpCastleNlogModule: AbpModule
    {
        public override void PreInitialize()
        {
           // Configuration.ReplaceService<ILoggerFactory, NlogLoggerFactory>(DependencyLifeStyle.Singleton);

            //IocManager.Register<LoggingConfiguration>();

            //IocManager.Register<ILoggerFactory, NlogLoggerFactory>();

            //IocManager.IocContainer.Register(Component
            //    .For<ILogger>()
            //    .UsingFactoryMethod((kernel, componentModel, creationContext)
            //        => kernel.Resolve<ILoggerFactory>().Create(creationContext.Handler.ComponentModel.Name))
            //    .LifestyleTransient());
        }
    }
}