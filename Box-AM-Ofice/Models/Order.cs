﻿using Box_AM_Ofice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace boxAmOffice.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
