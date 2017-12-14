using System.ComponentModel.DataAnnotations;

namespace YkAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}