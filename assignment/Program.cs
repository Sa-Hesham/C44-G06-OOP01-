

using System;
using System.Drawing;
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

            //Permission permissions = Permission.None;
            //bool flag;



            //    Console.WriteLine("please enter permision   ");
            //    flag = Enum.TryParse(Console.ReadLine(), true, out Permission permission);

            //if (flag)

            //    permissions |= permission;   

            //else

            //    Console.WriteLine("Invalid permission!");

            ////Console.WriteLine(permissions);


            //Console.WriteLine("please enter permision   ");
            //flag = Enum.TryParse(Console.ReadLine(), true, out Permission permission2);


            //if (flag )

            //    permissions |= permission2;

            //else

            //    Console.WriteLine("Invalid permission!");

            //Console.WriteLine(permissions);


            #endregion




            #region Q4

            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            //as its members.Write a C# program that takes a color name as input from
            //the user and displays a message indicating whether the input color is a
            //primary color or not.

            Console.WriteLine("Please enter a color (Red, Green, Blue):");

          

            bool isValid = Enum.TryParse(Console.ReadLine(), true, out Colors color);

            if (isValid)
            {
                if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
                {
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{color} is not a primary color.");
                }
            }
            else
            {
                Console.WriteLine("Invalid color entered.");
            }


            #endregion
        }


        #region Part1

//Try all what we have learned in the lecture.

/*
 * i learned  
 * 1- class library : it is acollection of clasess we can use it  in many projects  has one file (dll file ) and not excutable file 
 *2- user defined data taypes[struct - enum _ interface _class ]
 *3- we can write unde namespace scope five user defined datataypes[class -enum - struct _ interface delegate ]
 *4- Access Modifier Allowed 
 * inside name space we can used two access modifier  internal and public  with all  user defined data type  
 * internal we can used the datatype within file only  
 * public  we can use it in all project
 * 
 * 5 access modifire with  class , interface ,struct 
 * 1-class we can use [private - by-default] [internal]==>inside the cope and project only [public] can access every where in same project
 * we can write inside the class [attributes - properties - function events ]
 * 
 * 2- struct we can use [private - by-default] [internal]==>inside the cope and project only [public] can access every where in same project
 * we can write inside the class [attributes - properties - function events ]  
 * 
 * 3- interFace it acode contract 
 * we can write insde  signature methods 
 * and sinature properties  and default implemented method 
 * access modifires  [public [default] - internal -  private [default for implemented method ] - protected - internal protected - private protected ]
 * 
 * 
 * 
 * 4 enums  it is aspecial value has  acollectaion of constant values 
 * can write insde lables 
 * Enums are strongly typed constants.
 */


#endregion

}
}
