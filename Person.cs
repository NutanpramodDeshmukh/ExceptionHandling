using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDetermination
{
    public class Person
    {
        int age;
        
        public Person(int age)
        {
            this.age = age;
            
        }

        public void Category()
        {
            try
            {
                if (age >= 1 && age <= 14)
                {
                    Console.WriteLine("Children");
                }
                else if(age >= 15 && age <= 24)
                {
                    Console.WriteLine("Youth");
                }
                else if (age >= 25 && age <= 64)
                {
                    Console.WriteLine("Adult");
                }
                else if (age >= 64)
                {
                    Console.WriteLine("Senior");
                }
                else
                {
                    Console.WriteLine("Invalid Age");
                    throw new CustomException(CustomException.ExceptionType.Null, "Null message not valid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.Empty, "Null message not valid");  

            }
        }
    }
}
