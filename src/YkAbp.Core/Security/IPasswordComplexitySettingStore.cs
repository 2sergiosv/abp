using System.Threading.Tasks;

namespace YkAbp.Core.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
