using System.Collections.Generic;
using YkAbp.Core.MultiTenancy.Payments;

namespace YkAbp.Application.Editions.Dto
{
    public class EditionSelectDto
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string DisplayName { get; set; }

        public int? ExpiringEditionId { get; set; }

        public decimal? MonthlyPrice { get; set; }

        public decimal? AnnualPrice { get; set; }

        public int? TrialDayCount { get; set; }

        public int? WaitingDayAfterExpire { get; set; }

        public bool IsFree { get; set; }

        public Dictionary<ESubscriptionPaymentGatewayType, Dictionary<string, string>> AdditionalData { get; set; }

        public EditionSelectDto()
        {
            AdditionalData = new Dictionary<ESubscriptionPaymentGatewayType, Dictionary<string, string>>();
        }
    }
}