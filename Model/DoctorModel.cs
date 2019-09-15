using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DoctorModel
    {
        public int DoctorID { get; set; }

        [Required(ErrorMessage = "Please enter the First Name ")]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "Maximum of First Name is 50 charchters")]
        [RegularExpressionAttribute(@"^[a-zA-Z0-9-&.()_, \n\r]+$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the Last Name ")]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Maximum of Last Name is 50 charchters")]
        [RegularExpressionAttribute(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter the Contact Number")]
        [Display(Name = "Contact Number")]
        // [DataType(DataType.PhoneNumber)]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter the 10 digit Contact number")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Contact number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime DOB { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter the Valid age")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter the Valid age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select the Gender")]
        public string Gender { get; set; }

        [Display(Name="About Doctor")]
        public string AboutDoctor { get; set; }

        public List<DoctorDegreeModel> lstDegree { get; set; }

           [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }


           [Required(ErrorMessage = "Please enter the From Time")]
           public string FrmTime { get; set; }


           [Required(ErrorMessage = "Please enter the To Time")]
           public string ToTime { get; set; }

           [Required(ErrorMessage = "Please enter the Username ")]
          // [Display(Name = "First Name")]
           [StringLength(50, ErrorMessage = "Maximum of First Name is 50 charchters")]
           [RegularExpressionAttribute(@"^[a-zA-Z0-9-&.()_, \n\r]+$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
           public string Username { get; set; }

           public string Type { get; set; }

           [Required(ErrorMessage = "Please enter the UserCode")]
          // [Display(Name = "First Name")]
           [StringLength(50, ErrorMessage = "Maximum of First Name is 50 charchters")]
           [RegularExpressionAttribute(@"^[a-zA-Z0-9-&.()_, \n\r]+$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
           public string UserCode { get; set; }

           public string Password { get; set; }

         [Required(ErrorMessage = "Please enter the Degree ")]
           public string Degree { get; set; }
    }

    public class DoctorDegreeModel
    {
        public int DegreeID { get; set; }

        [Required(ErrorMessage="Please select the Degree")]
        [Display(Name="Degree Name")]
        public string DegreeName { get; set; }

    }
}
