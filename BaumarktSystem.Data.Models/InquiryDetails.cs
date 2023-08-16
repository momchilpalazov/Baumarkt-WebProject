using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Data.Models
{
    public class InquiryDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InquiryHeaderId { get; set; }

       
        [ForeignKey(nameof(InquiryHeaderId))]
        public virtual InquiryHedaer InquiryHedaer { get; set; }

        [Required]
        public int ProductId { get; set; }

        
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

      



    }
}
