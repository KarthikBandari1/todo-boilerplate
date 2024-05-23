using System.ComponentModel.DataAnnotations;

namespace todo3.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}