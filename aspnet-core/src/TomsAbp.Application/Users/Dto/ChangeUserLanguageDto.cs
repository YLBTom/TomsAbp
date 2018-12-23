using System.ComponentModel.DataAnnotations;

namespace TomsAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}