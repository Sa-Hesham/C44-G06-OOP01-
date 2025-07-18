

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment
{


    internal class Program
    {

         static void Main()
        {



            #region Q1
            ////1- Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members.Then, write a C# program that
            //prints out all the days of the week using this enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays))) 
            //{
            //    Console.WriteLine($"{day} = {(int) day}");
            //}



            #endregion



            #region Q2
            //2.Create an enum called "Season" with the four seasons(Spring,
            //Summer, Autumn, Winter) as its members.Write a C# program that
            //takes a season name as input from the user and displays the
            //corresponding month range for that season. Note range for seasons (
            //spring march to may , summer june to august, autumn September to
            //November, winter December to February)

            //bool Flag;
            //Seasons season;
            //do
            //{
            //    Console.WriteLine("please enter seassons");

            //    Flag = Enum.TryParse(Console.ReadLine(), true, out season);
            //} while (!Flag);


            //if (season == Seasons.winter)
            //{
            //    Console.WriteLine("December to February");

            //}
            //else if (season == Seasons.spring)
            //{
            //    Console.WriteLine("March to May");
            //}
            //else if (season == Seasons.fall) {

            //    Console.WriteLine("September to November");
            //}
            //else
            //{
            //    Console.WriteLine("June to August");
            //}


            #endregion



            #region Q3

            Permission permissions = Permission.None;
            bool flag;

           
          
                Console.WriteLine("please enter permision   ");
                flag = Enum.TryParse(Console.ReadLine(), true, out Permission permission);

            if (flag)
            
                permissions |= permission;   
            
            else
            
                Console.WriteLine("Invalid permission!");

            //Console.WriteLine(permissions);


            Console.WriteLine("please enter permision   ");
            flag = Enum.TryParse(Console.ReadLine(), true, out Permission permission2);


            if (flag )

                permissions |= permission2;

            else

                Console.WriteLine("Invalid permission!");

            Console.WriteLine(permissions);


            #endregion
        }

    }
    }
