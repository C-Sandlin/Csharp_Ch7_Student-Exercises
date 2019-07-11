using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        private string _cohort;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Specialty { get; set; }


        public Instructor(string firstname, string lastname, string slackhandle, string specialty, string cohort)
        {
            _cohort = cohort;
            FirstName = firstname;
            LastName = lastname;
            Specialty = specialty;
        }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
            // foreach (Exercise exercise in ExerciseList)
            // {
            //     Console.WriteLine($"{student} has been assigned the exercise {exercise}");
            // }
        }
    }
}
