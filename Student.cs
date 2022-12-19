using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassTask
{
    internal class Student
    {
        string Name;
        string Surname;
        int Point;
        int Group;
        bool graduation;


       public Student(string name,string surname,int group,int point)//Bu exception duzeltmek.
        {
            this.Name = name;
            this.Surname = surname;
            this.Point = point;
            this.Group = group;
            int order=0;
            while (Name!=null&&Surname!=null&&Point!=0&&Group!=0)//Whilenin islememesi.
            {
                Console.WriteLine("If you want to check your Name and Surname pls press 1.");
                Console.WriteLine("If you want to check your Point pls press 2.");
                Console.WriteLine("If you want to check your group number pls press 3.");
                Console.WriteLine("If you want to check your graduation pls press 4.");
                Console.WriteLine("If you want to get all information pls press 5.");
                Console.WriteLine("If you want you exit press 6.");
                Console.Write("----Give your order:");
                order = int.Parse(Console.ReadLine());//Bu exceptionu duzeltmek.
                Console.Clear();
                Console.WriteLine("Here is your order:");
                switch (order)
                {
                    case 1:
                        GetNameSurname();
                        break;
                    case 2:
                        PointCheck();
                        break;
                    case 3:
                        GroupCheck();
                        break;
                    case 4:
                        GraduationCheck();
                        break;
                    case 5:
                        AllInfo();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Wrong Order.");
                        break;

                }
                Console.WriteLine("Something went wrong.");
               


            }


        }
        //Methodun static verilmeyende program.cs de islememesi ?
        public void GetNameSurname()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
        
        public void PointCheck()
        {
            Console.WriteLine($"{Point}");
        }

        public void GroupCheck()
        {
            Console.WriteLine($"{Group}");
        }
        public bool GraduationCheck()
        {
            if (Point>80)
            {
                graduation = true;
            }
            else
            {
                graduation = false;

            }
            switch(graduation)
            {
                case true:
                    Console.WriteLine("You can get graduation.");

                    return true;
                    
                case false:
                    int need = 80 - Point;
                    
                    Console.WriteLine($"You cant get graduation. You need {need} points.");
                    return false;


            }

        }

        public void AllInfo()
        {
            Console.WriteLine($"Name and Surname:{Name} {Surname} Point:{Point} Group:{Group} Point{Point} Graduation{ GraduationCheck()}");
        }




    }
}
