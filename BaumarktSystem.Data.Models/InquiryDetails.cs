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

        [Required]
        [ForeignKey(nameof(InquiryHeaderId))]
        public virtual InquiryHedaer InquiryHedaer { get; set; }=new InquiryHedaer();

        [Required]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }=   new Product();

        public int Quantity { get; set; }



    }
}
