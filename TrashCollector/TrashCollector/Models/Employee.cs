﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
   
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is a Required Input")]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public int TrashPickUpToday { get; set; }
        public string FilterCustomerPickUp { get; set; }
        public bool ConfirmPickUp { get; set; }

        public double ChargedConfirmedPickUp { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [NotMapped]
        public List<int> ZipCodes { get; set; }
    }
}
