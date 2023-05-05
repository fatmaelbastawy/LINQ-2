using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Topic
    {
        [Key]
        public int Topic_Id { get; set; }
        public string Topic_Name { get; set; }
    }
}
