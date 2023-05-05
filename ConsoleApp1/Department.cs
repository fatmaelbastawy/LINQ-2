using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public string Dept_desk { get; set; }
        public string Dept_Loc { get; set; }
        public DateTime Manager_Hiredate { get; set; }
        //[ForeignKey("Ins")]
        public int Ins_Id { get; set; }
        //public virtual Instructor Ins { get; set; }
    }
}
