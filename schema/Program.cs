using System;

namespace schema
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input for all values

            //Different subjects
            string subject = "";
            while(subject != "done" && subject != "Done" && subject != "DONE")
            {
                Console.WriteLine("Add the different subjects, Write DONE when all have been added");
                subject = Console.ReadLine();
                //Add subject to a list
            }

            //Teachers and their subjects
            string teacher = "";
            while (teacher != "done" && teacher != "Done" && teacher != "DONE")
            {
                Console.WriteLine("Add the different subjects, Write DONE when all have been added");
                teacher = Console.ReadLine();
                //Add teacher to a list
            }

            for (int i = 0; i < /*either techer list or the subject list*/; i++)
            {
                Console.WriteLine("What subject is: "/*the first techer*/ + "The tutor for? Chose in the list below" );
                //Print list of all the subjects


            }
            

            Console.WriteLine("What subject 1 - **");

            

            //Different study halls


            //*

            //class (name)

            //Subjects (names from a list)

            //Amount of time each week (hour format)

            //Repeat to * for every class


            //Press GO

            
            
        }
    }
}
