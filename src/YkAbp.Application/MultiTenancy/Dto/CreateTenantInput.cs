using System;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using YkAbp.Core;

namespace YkAbp.Application.MultiTenancy.Dto
{
    public class CreateTenantInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        [RegularExpression(YkAbpConsts.TenancyNameRegex)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(YkAbpConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        [StringLength(AbpUserBase.MaxPasswordLength)]
        public string AdminPassword { get; set; }

        [MaxLength(AbpTenantBase.MaxConnectionStringLength)]
        public string ConnectionString { get; set; }

        public bool ShouldChangePasswordOnNextLogin { get; set; }

        public bool SendActivationEmail { get; set; }

        public int? EditionId { get; set; }

        public bool IsActive { get; set; }

        public DateTime? SubscriptionEndDateUtc { get; set; }

        public bool IsInTrialPeriod { get; set; }
    }
}