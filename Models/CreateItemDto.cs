using System.ComponentModel.DataAnnotations;

namespace RestApiExercise.Models
{
    public class CreateItemDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}