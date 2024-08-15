using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        [Required]
        public string Name { get; set; }

        [StringLength(20)]
        [Required]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Range(1, 100)]
        public City City { get; set; }

        [EmailAddress]
        [Required]
        [StringLength(25)]
        public string Email { get; set; }

        //[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }

        public bool AllowNewsLetter { get; set; }
    }
}
