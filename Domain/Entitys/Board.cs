using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entitys
{
    public class Board
    {
        public Board(string name, string description)
        {
            Name = name;
            Description = description;
        }


        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public List<Tasks> Tasks { get; set; }
    }
}
