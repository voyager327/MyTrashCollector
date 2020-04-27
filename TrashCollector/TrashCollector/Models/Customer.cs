using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is a Required Input")]
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PickUpDay { get; set; }
        public DateTime OneTimePickUpSpecificDate { get; set; }
        public double MonthlyAccountBalance { get; set; }
        public DateTime StartDateTemporaySuspension { get; set; }
        public DateTime EndDateTemporarySuspension { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [NotMapped]
        public List<string> PickUpDays { get; set; }
       
    }

}
