using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserModel
    {
        public Int64 UserID { get; set; }

        
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Maximum length is 10 and Minmum length 4")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter the valid Usercode")]
        [StringLength(10, MinimumLength = 4)]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string UserCode { get; set; }

        [Required(ErrorMessage = "Please enter the Password")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public string UserType { get; set; }

        public int UserTypeValue { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int UpdatedBy { get; set; }

        public string CreatedIp { get; set; }

    }

    public class DropDown
    {
        public string Text { get; set; }

        public string Value { get; set; }
    }
}
