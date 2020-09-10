using System.ComponentModel.DataAnnotations;

namespace MainCommander.Dtos
{
    public class MainCommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }

    }
}