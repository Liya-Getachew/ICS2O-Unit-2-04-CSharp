// Created by: liya getachew
// Created on: Oct 12 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseOfTriangle;
        int heightOfTriangle;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter base of triangle (cm): ");
        baseOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of triangle (cm): ");
        heightOfTriangle = Convert.ToInt32(Console.ReadLine());

        int area = (baseOfTriangle * heightOfTriangle) / 2;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm².");

        Console.WriteLine("\nDone.");
    }
}
