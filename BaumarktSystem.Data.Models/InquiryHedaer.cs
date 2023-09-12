using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Data.Models
{
    public class InquiryHedaer
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        public string? FullName { get; set; }
        //[Required]
        public string?  PhoneNumber { get; set; }
        //[Required]
        public string?  Email { get; set; }
        public DateTime InquiryDate { get; set; }


        public Guid ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser ApplicationUser { get; set; }


        


    }
}
