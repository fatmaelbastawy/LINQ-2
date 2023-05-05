using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Context:DbContext
    {
        public Context():base(@"Data source=.;Initial catalog=Justtest;integrated security=true")
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        //public virtual DbSet<Ins_Crs> Ins_Crs { get; set; }

    }
}
