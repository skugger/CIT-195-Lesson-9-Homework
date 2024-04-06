using System;
using System.Security.Cryptography;

namespace CIT_195_Lesson_9_Operator_Overloading_Homework
{
    public class Lesson
    {
        public int Exercise1 { get; set;}
        public int Exercise2 { get; set;}
        public int Exercise3 { get; set;}

        public int totalHours()
        {
            return Exercise1 + Exercise2 + Exercise3;
        }
        public static bool operator >(Lesson one, Lesson two)
        {
            return one.totalHours() > two.totalHours(); 
        }
        public static bool operator <(Lesson one, Lesson two)
        {
            return one.totalHours() < two.totalHours(); 
        }
        public static Lesson operator +(Lesson lesson1, Lesson lesson2)
        {
            Lesson result = new Lesson();
            result.Exercise1 = lesson1.Exercise1 + lesson2.Exercise1;
            result.Exercise2 = lesson1.Exercise2 + lesson2.Exercise2;
            result.Exercise3 = lesson1.Exercise3 + lesson2.Exercise3;
            return result;
        }
        public static Lesson operator --(Lesson lesson)
        {
            lesson.Exercise1--;
            lesson.Exercise2--;
            lesson.Exercise3--;
            return lesson;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lesson Lesson1 = new Lesson();
            Lesson Lesson2 = new Lesson();

            Random r = new Random();
            Lesson1.Exercise1 = (r.Next(1, 5)+1);
            Lesson1.Exercise2 = (r.Next(1, 5)+1);
            Lesson1.Exercise3 = (r.Next(1, 5)+1);
            Lesson2.Exercise1 = (r.Next(1, 5)+1);
            Lesson2.Exercise2 = (r.Next(1, 5)+1);
            Lesson2.Exercise3 = (r.Next(1, 5)+1);

            Console.WriteLine("Regarding this week's homework...");
            Console.WriteLine("You have two lessons to do, and each lesson has two exercises.");

            Console.WriteLine();
            Console.WriteLine($"Lesson 1, Exercise 1 will take {Lesson1.Exercise1} hours, and");
            Console.WriteLine($"Lesson 1, Exercise 2 will take {Lesson1.Exercise2} hours, and");
            Console.WriteLine($"Lesson 1, Exercise 3 will take {Lesson1.Exercise3} hours.");

            Console.WriteLine();
            Console.WriteLine($"Lesson 2, Exercise 1 will take {Lesson2.Exercise1} hours, and");
            Console.WriteLine($"Lesson 2, Exercise 2 will take {Lesson2.Exercise2} hours, and");
            Console.WriteLine($"Lesson 2, Exercise 3 will take {Lesson2.Exercise3} hours.");


            Console.WriteLine();
            bool Largest = Lesson1 > Lesson2;
            Console.WriteLine($"Lesson 1 will take {Lesson1.totalHours()} hours, and Lesson 2 will take {Lesson2.totalHours()} hours.");
            Console.WriteLine($"So it would be {Largest} to say that Lesson 1 will take longer than Lesson 2.");

            Console.WriteLine();
            Lesson totalLesson = Lesson1 + Lesson2;
            Console.WriteLine($"Total hours for Exercise 1: {totalLesson.Exercise1}");
            Console.WriteLine($"Total hours for Exercise 2: {totalLesson.Exercise2}");
            Console.WriteLine($"Total hours for Exercise 3: {totalLesson.Exercise3}");

            Console.WriteLine();
            Console.WriteLine("You're a pretty smart student, we should reduce the Lesson 2 estimates by 1 hour each.");

            Lesson2--;

            Console.WriteLine();
            Console.WriteLine($"Lesson 2, Exercise 1 will take {Lesson2.Exercise1} hours, and");
            Console.WriteLine($"Lesson 2, Exercise 2 will take {Lesson2.Exercise2} hours, and");
            Console.WriteLine($"Lesson 2, Exercise 3 will take {Lesson2.Exercise3} hours.");


        }
    }
}