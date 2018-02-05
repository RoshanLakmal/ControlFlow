using System;

namespace ControlFlow
{
    class MainClass
    {
        public enum imageMode
        {
            portrait =1,
            landscape = 2
        }
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

            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter Number1: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            var num2 = Convert.ToDouble(Console.ReadLine());
            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Max: "+max);

            //3 - Write a program and ask the user to enter the width and height of an image.
            //Then tell if the image is landscape or portrait.
            Console.WriteLine("Enter the width: ");
            var width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            var height = Convert.ToDouble(Console.ReadLine());
            var img = (width > height) ? imageMode.landscape : imageMode.portrait;
            Console.Write(img);

            //4 - Your job is to write a program for a speed camera.
            //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //If the number of demerit points is above 12, the program should display License Suspended.
            Console.WriteLine("Enter Speed Limit: ");
            var speedLimit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Speed of a car: ");
            var carSpeed = Convert.ToDouble(Console.ReadLine());
            if(carSpeed<speedLimit){
                Console.WriteLine("Ok");
            }else{
                var overFlowSpeed = carSpeed - speedLimit;
                var points = overFlowSpeed / 5;
                var result = (points > 12) ? "License Suspended" : "Demerit Points: " + points;
                Console.WriteLine(result);
            }
		}
    }
}
