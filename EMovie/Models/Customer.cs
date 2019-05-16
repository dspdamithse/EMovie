using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace EMovie.Models
{
    public class Customer
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetters { get; set; }
        public MembershipType MembershipTypes { get; set; }
        public byte MembershipTypeId { get; set; }


    }
}