using Abp.Configuration;

namespace YkAbp.Application.Timing.Dto
{
    public class GetTimezonesInput
    {
        public SettingScopes DefaultTimezoneScope { get; set; }
    }
}
