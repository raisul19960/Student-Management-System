using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Banglafire_Solution_Ltd_Task.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required, StringLength(50), Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
        [Required, StringLength(50), Display(Name = "Section Name")]
        public string Section { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {
            Database.SetInitializer(new StudentInitializer());
        }
        public DbSet<Student> Students { get; set; }
    }
    public class StudentInitializer : DropCreateDatabaseIfModelChanges<StudentDbContext>
    {

        protected override void Seed(StudentDbContext context)
        {
            if (context != null)
            {
                Student student1 = new Student { StudentName = "Md Akram", DateOfBirth = new DateTime(2020, 02, 01), Class = "Six", Section = "A" };
                Student student2 = new Student { StudentName = "Juyel Rana", DateOfBirth = new DateTime(2020, 02, 01), Class = "Six", Section = "B" };
                Student student3 = new Student { StudentName = "Hasan Mahmud", DateOfBirth = new DateTime(2020, 02, 01), Class = "Six", Section = "C" };
                Student student4 = new Student { StudentName = "Rakib Hasan", DateOfBirth = new DateTime(2020, 02, 01), Class = "Seven", Section = "A" };
                Student student5 = new Student { StudentName = "Sharmin Akter", DateOfBirth = new DateTime(2020, 02, 01), Class = "Six", Section = "B" };
                context.Students.Add(student1);
                context.Students.Add(student2);
                context.Students.Add(student3);
                context.Students.Add(student4);
                context.Students.Add(student5);
                context.SaveChanges();
            }
            else
            {

            }
        }
    }

}