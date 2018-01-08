using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using Microsoft.EntityFrameworkCore;
using YkAbp.Core;

namespace YkAbp.EntityFrameworkCore.Seed.Host
{
    internal class DefaultSettingsCreator
    {
        private readonly YkAbpDbContext _context;

        public DefaultSettingsCreator(YkAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            // Emailing
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "admin@mydomain.com");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "mydomain.com mailer");

            // Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, YkAbpConsts.DefaultLanguae);
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}
