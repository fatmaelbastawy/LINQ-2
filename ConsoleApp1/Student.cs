using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        [Key]
        public int St_Id { get; set; }
        public string St_FName { get; set; }
        public string St_LName { get; set; }
        public int St_Age { get; set; }
        public string St_Address { get; set; }
        [ForeignKey("Dept"),Required]
        public int Dept_Id { get; set; }
        public virtual Department Dept { get; set; }

        //[ForeignKey("Dept")]
        //public int St_super { get; set; }
        
    }
}
