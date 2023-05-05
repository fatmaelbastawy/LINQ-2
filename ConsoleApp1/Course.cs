using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course
    {
        [Key]
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_Duration { get; set; }
        [ForeignKey("Top"),Required]
        public int Topic_Id { get; set; }
        public virtual Topic Top { get; set; }
        public virtual List<Ins_Crs> Ins_Crs { get; set; }
    }
}
