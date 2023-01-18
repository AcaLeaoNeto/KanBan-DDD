using System.ComponentModel.DataAnnotations;

namespace Domain.Entitys.Dtos
{
    public class DtoBoard
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
