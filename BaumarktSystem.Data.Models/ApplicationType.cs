﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BaumarktSystem.Common.EntityValidationConstanst.ApplicationType;

namespace BaumarktSystem.Data.Models
{
    public class ApplicationType
    {
       

        

        [Key]
        public int Id { get; set; } 

        [Required]
       
        public string Name { get; set; }=null!;

        [Required]
        //USer
        public Guid CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; } = null!;


       

        public DateTime CreatedOn { get; set; }


        public ICollection<Product> Products { get; set; } = new HashSet<Product>();






    }
}