using System;
using System.Collections.Generic;
using System.Threading;

namespace schema
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input for all values


            //Different subjects

            List<string> subjects = new List<string>();
            string subjectInput = "";
            while(subjectInput != "done" && subjectInput != "Done" && subjectInput != "DONE")
            {
                Console.WriteLine("Add the different subjects, Write DONE when all have been added, if you wan't to remove a subject write REMOVE and follow the stepps");
                subjectInput = Console.ReadLine();

                //Adds the subject to a subject list
                subjects.Add(subjectInput);

                //Add a way to remove subjects
                Console.Clear();
            }


            //Adding the teachers to the list

            List<string> teachers= new List<string>();
            string teacherInput = "";
            while (teacherInput != "done" && teacherInput != "Done" && teacherInput != "DONE")
            {
                Console.WriteLine("Add the different subjects, Write DONE when all have been added, if you wan't to remove a techers write REMOVE and follow the stepps");
                teacherInput = Console.ReadLine();

                //Add teacher to a list
                teachers.Add(teacherInput);

                //Add a way to remove teachers
                Console.Clear();
            }


            //Making a path between teacher list and subject list 

            List<int> teacher_subject_crossover = new List<int>();
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine("What subject is: " + teachers[i] + "The tutor for? Chose in the list below" );

                //Print list of all the subjects

                for (int j = 0; j < subjects.Count; j++)
                {
                    Console.WriteLine($"({j + 1})  " + subjects[j]);
                }

                int subject_Teacher = Convert.ToInt32(Console.ReadLine());

                teacher_subject_crossover.Add(subject_Teacher - 1);

                Console.Clear();
            }


            //Different classroom

            List<string> classrooms = new List<string>();
            string classroomInput = "";
            while (classroomInput != "done" && classroomInput != "Done" && classroomInput != "DONE")
            {
                Console.WriteLine("Add the different classrooms with numbers, Write DONE when all have been added, if you wan't to remove a classroom write REMOVE and follow the stepps");
                classroomInput = Console.ReadLine();

                //Add teacher to a list
                classrooms.Add(classroomInput);

                //Add a way to remove teachers
                Console.Clear();
            }


            //Create the different classes
            List<string>

            Console.WriteLine("Input the class name");




            //*

            //class (name)

            //Subjects (names from a list)

            //Amount of time each week (hour format)

            //Repeat to * for every class


            //Press GO



        }
    }
}
