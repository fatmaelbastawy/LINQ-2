using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        public string Ins_Name { get; set; }
        public string Ins_Degree { get; set; }
        public double Ins_Salary { get; set; }
        [ForeignKey("Dept"),Required]
        public int Dept_Id { get; set; }
        public virtual Department Dept { get; set; }
        public virtual List<Ins_Crs> Ins_Crs { get; set; }

    }
}
