using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BaumarktSystem.Data.Models
{
    public class CartItem
    {

        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }=null!;

        public Guid? ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]

        public virtual ApplicationUser? ApplicationUser { get; set; }=null!;



    }
}
