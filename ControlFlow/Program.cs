﻿using System;

namespace ControlFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.
            //Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            Console.WriteLine("Enter a number: ");
            var numberInput = Convert.ToInt32(Console.ReadLine());
            if(numberInput>=1 && numberInput<=10){
                Console.WriteLine("Valid");
            }else{
                Console.WriteLine("Invalid");
            }
        }
    }
}
