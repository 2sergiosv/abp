using System.ComponentModel.DataAnnotations;

namespace YkAbp.Application.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}