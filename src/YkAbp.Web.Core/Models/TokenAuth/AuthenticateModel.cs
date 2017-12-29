using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace YkAbp.Web.Core.Models.TokenAuth
{
    public class AuthenticateModel
    {
        /// <summary>
        /// 用户名或者绑定的Email
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string UserNameOrEmailAddress { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        public string Password { get; set; }
        
        /// <summary>
        /// 是否保持登录
        /// </summary>
        public bool RememberClient { get; set; }
    }
}
