using System.ComponentModel.DataAnnotations;

namespace YkAbp.Application.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}