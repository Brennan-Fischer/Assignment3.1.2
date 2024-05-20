using System.Security.Cryptography.X509Certificates;

namespace Assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         MyMethods.IsYearLeap(2024);
        }

        static public class MyMethods
        {
            static public bool IsYearLeap(int myYear)
            {
                bool isYearLeap;

                if (myYear%4 == 0)
                {
                    isYearLeap = true;
                    Console.WriteLine(Convert.ToString(isYearLeap) + " "+ Convert.ToString(myYear) + " year is a leap year");
                }
                else
                {
                    isYearLeap = false;
                    Console.WriteLine(Convert.ToString(isYearLeap) + "year is not a leap year");
                }
                return isYearLeap;
            }
        }
    }
}
