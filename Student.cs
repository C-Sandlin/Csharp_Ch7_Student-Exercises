using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        private string _cohort;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public List<Exercise> ExerciseList { get; set; }

        public Student(string firstname, string lastname, string slackhandle, string cohort)
        {
            _cohort = cohort;
            FirstName = firstname;
            LastName = lastname;
            ExerciseList = new List<Exercise>();
        }

        public void ShowAssignedExercises()
        {
            Console.WriteLine($"{FirstName} {LastName}'s exercises include:");
            foreach (Exercise exercise in ExerciseList)
            {
                Console.WriteLine($"{exercise.Name}, written in {exercise.Language}");
            }
        }
    }
}
