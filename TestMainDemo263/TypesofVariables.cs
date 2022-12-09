using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofVariables
{
    internal class TypesofVariables
    {
        //Default constructor
        public TypesofVariables()
        {
            Console.WriteLine("Default constructor");
        }

        // Paramitrized constructor
        public TypesofVariables(int phone)
        {
            Console.WriteLine("Parameterized constructor" +phone);
        }


        // Local variable - Scope is only to the method
        public static void StudentAge(int phoneNumber)
        {
            int age = 18;
            age = age + 10;
            Console.WriteLine("Student age is {0} and phoneNumber is {1}: ", age, phoneNumber);
        }


    }
}