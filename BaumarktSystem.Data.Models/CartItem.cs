﻿using System;
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

        [NotMapped]
        public int Quantity { get; set; }

       

    }
}
