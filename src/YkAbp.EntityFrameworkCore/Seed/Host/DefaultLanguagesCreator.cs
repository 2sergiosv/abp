using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using YkAbp.Core;

namespace YkAbp.EntityFrameworkCore.Seed.Host
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages => GetInitialLanguages();

        private readonly YkAbpDbContext _context;

        private static List<ApplicationLanguage> GetInitialLanguages()
        {
            var tenantId = YkAbpConsts.MultiTenancyEnabled ? null : (int?)1;
            return new List<ApplicationLanguage>
            {
                new ApplicationLanguage(tenantId, "zh-CN", "简体中文", "famfamfam-flags cn"),
                new ApplicationLanguage(tenantId, "en", "English", "famfamfam-flags gb"),
            };
        }

        public DefaultLanguagesCreator(YkAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateLanguages();
        }

        private void CreateLanguages()
        {
            foreach (var language in InitialLanguages)
            {
                AddLanguageIfNotExists(language);
            }
        }

        private void AddLanguageIfNotExists(ApplicationLanguage language)
        {
            if (_context.Languages.IgnoreQueryFilters().Any(l => l.TenantId == language.TenantId && l.Name == language.Name))
            {
                return;
            }

            _context.Languages.Add(language);

            _context.SaveChanges();
        }
    }
}