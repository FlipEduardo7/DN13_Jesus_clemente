using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Memberships
{
    public class Membership
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid money format.")]
        public double Cost { get; set; }

        [Required]
        public string CreatedOn { get; set; }

        [Required]
        [Range(1,12)]
        public int Duration { get; set; }
    }
}
