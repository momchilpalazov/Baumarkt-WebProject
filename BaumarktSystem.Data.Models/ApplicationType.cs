using System.ComponentModel.DataAnnotations;
using static BaumarktSystem.Common.EntityValidationConstanst.ApplicationType;

namespace BaumarktSystem.Data.Models
{
    public class ApplicationType
    {
        

        [Key]
        public int Id { get; set; } 

        [Required]
       
        public string Name { get; set; }=null!;


        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        

       

    }
}