using System.ComponentModel.DataAnnotations;

namespace Domain.Entitys.Dtos
{
    public class DtoTasks
    {
        [Required]
        public int BoardId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
