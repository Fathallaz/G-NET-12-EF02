using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G_NET_12_EF02
{
    internal class Organizer
    {
        [Key]
         public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string? CompanyName { get; set; }
        
        public bool IsVerified { get; set; }
        [MaxLength(1000)]
        public string Biography { get; set; }
        [Url]
        public string? WebsiteUrl { get; set; }
        public string? Logo { get; set; }
        
        
    }
}
