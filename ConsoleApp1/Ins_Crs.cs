using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ins_Crs
    {
        public int Id { get; set; }
        [ForeignKey("Ins")]
        public int Ins_Id { get; set; }
        [ForeignKey("Crs")]
        public int Crs_Id { get; set; }
        public int Evaluation { get; set; }
        public virtual Instructor Ins { get; set; }
        public virtual Course Crs { get; set; }
        
    }
}
