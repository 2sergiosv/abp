using System.ComponentModel.DataAnnotations;

namespace YkAbp.Application.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
