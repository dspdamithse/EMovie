﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EMovie.Models;

namespace EMovie.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetters { get; set; }

        public byte MembershipTypeId { get; set; }

        //[CheckCustomerAge]
        public DateTime? Birthdate { get; set; }
    }
}