﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolutions.Entity
{

    [Table("User")]
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("UserId")]
        public ICollection<Cart> Carts { get; set; }
        
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
