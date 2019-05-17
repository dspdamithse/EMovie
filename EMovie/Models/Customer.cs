using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace EMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }
     
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetters { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime? Birthdate { get; set; }



    }
}