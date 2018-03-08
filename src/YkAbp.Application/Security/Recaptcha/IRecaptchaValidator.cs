using System.Threading.Tasks;

namespace YkAbp.Application.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}