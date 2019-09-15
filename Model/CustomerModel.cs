using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class CustomerModel
    {
        #region

        public Int64 AppointmentID { get; set; }

        public string AppRefID { get; set; }


        [Required(ErrorMessage = "Please enter the First Name ")]
        [Display(Name="First Name")]
        [StringLength(50, ErrorMessage = "Maximum of First Name is 50 charchters")]
        [RegularExpressionAttribute(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the Last Name ")]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Maximum of Last Name is 50 charchters")]
        [RegularExpressionAttribute(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name="Email")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter the Contact Number")]
        [Display(Name = "Contact Number")]
       // [DataType(DataType.PhoneNumber)]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter the 10 digit Contact number")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Contact number")]
        public string PhoneNumber { get; set; }

        public DoctorModel Doctor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Date of birth")]
        public DateTime DOB { get; set; }
  
        [Range(0, 100, ErrorMessage = "Please enter the Valid age")]
        [RegularExpression(@"^[0-9]*$",ErrorMessage="Please enter the Valid age")]
        public int Age { get; set; }

     
        public string Gender { get; set; }

        [Display(Name = "From Date")]
        [DataType(DataType.DateTime)]
                public DateTime AppDateTime { get; set; }


        public string Descriptions { get; set; }

        public DateTime CreatedOn { get; set; }

        public Int64 CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string CreatedIP { get; set; }

        public int DoctorID { get; set; }
        #endregion
    }
}
