using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Instructor> InstructorList { get; set; }

        public Cohort(string cohortname)
        {
            CohortName = cohortname;
            StudentList = new List<Student>();
            InstructorList = new List<Instructor>();
        }
    }
}
