﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

       //public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[MinAge18ForMember]
        public DateTime? Birthdate { get; set; }

    }
}