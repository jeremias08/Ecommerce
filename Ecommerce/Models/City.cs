using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage = "The Field {0} is Required")]
        [MaxLength(50, ErrorMessage = "The field {0} must be maximun {1} characters length")]
        [Display(Name = "City")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Field {0} is Required")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}