using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MecidineModel
    {
        public Int64 MEDID { get; set; }

        [Required(ErrorMessage = "Please enter the Mecidine Name ")]
        [Display(Name = "Mecidine Name")]
        [StringLength(50, ErrorMessage = "Maximum of First Name is 50 charchters")]
        [RegularExpressionAttribute(@"^[a-zA-Z0-9-&.()_, \n\r]+$", ErrorMessage = "Only a-z,A-Z,0-9 is allowed")]
        public string MEDName { get; set; }

         
        [Required(ErrorMessage = "Please enter the Mecidine Price ")]
        [RegularExpression(@"^[0-9.]*$", ErrorMessage = "Please enter the Valid Price")]
        public double MEDPrice { get; set; }


        public string @IsAvailable { get; set; }

         [Required(ErrorMessage = "Please enter the Quantity ")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please enter the Valid Quantity")]
        public int Quantity { get; set; }

    }
}
