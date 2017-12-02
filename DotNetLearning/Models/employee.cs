using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//anotation for table maping
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNetLearning.Models
{
    //[Table("Employee")]
    public class Employees
    {
        [Key]
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

    }
}