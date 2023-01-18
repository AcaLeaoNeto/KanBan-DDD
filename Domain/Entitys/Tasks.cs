using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entitys
{
    public class Tasks
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int BoardId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public Board Board {get; set;}
    }
}
