using System.ComponentModel.DataAnnotations;

namespace MainCommander.Dtos
{
    public class MainCommandCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

    }
}