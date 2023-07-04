using System.ComponentModel.DataAnnotations;

namespace BaumarktSystem.Data.Models
{
    public class Type
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }=null!;

    }
}