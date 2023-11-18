using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaWebAPP.Models
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required int State { get; set; }

        [Required]
        public required DateTime CreationDate { get; set; }

        public DateTime? CompletedDate { get; set; }
    }

}