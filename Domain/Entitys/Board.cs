using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entitys
{
    public class Board
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public List<Tasks> Tasks { get; set; }
    }
}
