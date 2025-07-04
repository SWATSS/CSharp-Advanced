using System;
using System.ComponentModel;
using Assignment_01.Enum;
namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, Write a C# program that prints out all the days of the week using this Enum.
            //foreach (WeekDays day in System.Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Please Enter Months Name: ");
            //string M = Console.ReadLine();
            //if (System.Enum.TryParse(M, true, out Seas_on Season))
            //{
            //    string result = (Season == Seas_on.Spring) ? "Spring: March to May" : ((Season == Seas_on.Summer) ? "Summer: June to August" : ((Season == Seas_on.Autumn) ? "Autumn: September to November" : ((Season == Seas_on.Winter) ? "Winter: December to February" : "Invalid"))); ;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("invalid Enter :(");
            //}
            #endregion

            #region 3-Assign the following Permissions (Read, Write, Delete, Execute) in a form of Enum .Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
            Permissions userPermissions = Permissions.Read;
            userPermissions |= Permissions.Write; // Add
            Console.WriteLine(userPermissions);
            Console.WriteLine("**************************************************");
            if ((userPermissions & Permissions.Write) == Permissions.Write)
            {
                userPermissions ^= Permissions.Write; // Remove 
                Console.WriteLine(userPermissions);
            }
            Console.WriteLine("**************************************************");

            if ((userPermissions & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("User Have [Write] Permision");
            }
            else
            {
                Console.WriteLine("User Dont Have [Write] Permision");
            }
            #endregion
        }
    }
}
