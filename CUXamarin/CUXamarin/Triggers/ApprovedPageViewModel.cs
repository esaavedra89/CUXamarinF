using System;
using System.Collections.Generic;
using System.Text;

namespace CUXamarin.Triggers
{
    public class ApprovedPageViewModel
    {
        public List<Student> Students { get; set; }

        public ApprovedPageViewModel()
        {
            Students = new List<Student>
            {
                new Student
                {
                    Name = "Pedro Arreaola",
                    Score = 4.5
                },
                new Student
                {
                    Name = "Alberto Sosa",
                    Score = 3.5
                },
                new Student
                {
                    Name = "Julio Avendaño",
                    Score = 7.3
                },
                new Student
                {
                    Name = "Hector Perez",
                    Score = 10
                },
                new Student
                {
                    Name = "Ricardo Acosta",
                    Score = 10
                },
            };
        }
    }
}
