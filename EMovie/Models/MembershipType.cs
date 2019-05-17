using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMovie.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationForMonth { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte notselected = 0;
        public static readonly byte freeMembership = 1;
                
    }
}