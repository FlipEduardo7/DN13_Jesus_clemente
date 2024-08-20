using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GymManager_Web.Model
{
    public class MemberViewModel
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
        public int CityId { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        //[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }

        public bool AllowNewsLetter { get; set; }
    }
}
