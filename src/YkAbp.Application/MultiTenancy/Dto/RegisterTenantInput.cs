using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using YkAbp.Application.MultiTenancy.Payments.Dto;
using YkAbp.Core.MultiTenancy.Payments;

namespace YkAbp.Application.MultiTenancy.Dto
{
    public class RegisterTenantInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        public string AdminPassword { get; set; }

        [DisableAuditing]
        public string CaptchaResponse { get; set; }

        public ESubscriptionStartType SubscriptionStartType { get; set; }

        public ESubscriptionPaymentGatewayType? Gateway { get; set; }

        public int? EditionId { get; set; }

        public string PaymentId { get; set; }
    }
}