namespace YkAbp.Core.Emailing
{
    public interface IEmailTemplateProvider
    {
        string GetDefaultTemplate(int? tenantId);
    }
}
