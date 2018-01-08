using System.IO;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Localization.Sources;

namespace YkAbp.Core.Localization
{
    internal static class YkAbpLocalizationConfigurer
    {
        internal static void Configure(ILocalizationConfiguration localizationConfiguration, string contentRoot)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    YkAbpConsts.LocalizationSourceName,
                    new JsonFileLocalizationDictionaryProvider(
                       Path.Combine(contentRoot, "lang")
                    )
                )
            );

            // 对ABP默认语言进行扩展
            localizationConfiguration.Sources.Extensions.Add(
                new LocalizationSourceExtensionInfo(
                    "Abp",
                    new JsonFileLocalizationDictionaryProvider(
                        Path.Combine(contentRoot, "lang", "Abp")
                    )
                )
            );

            localizationConfiguration.Sources.Extensions.Add(
                new LocalizationSourceExtensionInfo(
                    "AbpWeb",
                    new JsonFileLocalizationDictionaryProvider(
                        Path.Combine(contentRoot, "lang", "AbpWeb")
                    )
                )
            );

            localizationConfiguration.Sources.Extensions.Add(
                new LocalizationSourceExtensionInfo(
                    "AbpZero",
                    new JsonFileLocalizationDictionaryProvider(
                        Path.Combine(contentRoot, "lang", "AbpZero")
                    )
                )
            );
        }
    }
}
