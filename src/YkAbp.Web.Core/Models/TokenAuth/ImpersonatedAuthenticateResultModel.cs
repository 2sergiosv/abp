namespace YkAbp.Web.Core.Models.TokenAuth
{
    public class ImpersonatedAuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }
    }
}