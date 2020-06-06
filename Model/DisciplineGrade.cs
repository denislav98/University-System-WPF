using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class DisciplineGrade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DisciplineGradeId { get; set; }
        public string Discipline { get; set; }
        public FormOfControl FormOfControl { get; set; }
        public int Grade { get; set; }
        public DateTime? LastChanged { get; set; }

        public int Course { get; set; }

        public Student Student { get; set; }

        public int StudentId { get; set; }

        public DisciplineGrade()
        {

        }

        public DisciplineGrade(string discipline, FormOfControl formOfControl, int grade, DateTime lastChanged, int course, int studentId)
        {
            Discipline = discipline;
            FormOfControl = formOfControl;
            Grade= grade;
            LastChanged = lastChanged;
            Course = course;
            StudentId = studentId;
        }
    }
}
