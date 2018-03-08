using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace YkAbp.Core.Emailing
{
    public class YkAbpSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public YkAbpSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}