using System;
using System.IO;
using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Localization.Sources;

namespace YkAbp.Core.Localization
{
    public static class YkAbpLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    YkAbpConsts.LocalizationSourceName,
                    new JsonFileLocalizationDictionaryProvider(
                       Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lang")
                    )
                )
            );

            // 对ABP默认语言进行扩展
            localizationConfiguration.Sources.Extensions.Add(
                new LocalizationSourceExtensionInfo(
                    "AbpWeb",
                    new JsonFileLocalizationDictionaryProvider(
                        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lang", "AbpWeb")
                    )
                )
            );

            localizationConfiguration.Sources.Extensions.Add(
                new LocalizationSourceExtensionInfo(
                    "AbpZero",
                    new JsonFileLocalizationDictionaryProvider(
                        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lang", "AbpZero")
                    )
                )
            );
        }
    }
}
