﻿/*  11. Adding polynomials
    Write a method that adds two polynomials. Represent them as arrays of their coefficients. 
    Write a program that reads two polynomials and prints their sum.
    Input: 
            On the first line you will receive the number N
            On the second line you will receive the first polynomial as coefficients separated by spaces
            On the third line you will receive the second polynomial as coefficients separated by spaces
   Output: Print the sum of the polynomials
   Constraints: 1 <= N <= 1024
   Sample tests: 
                    Input 	        Output
                    3               12 4 -2
                    5 0 1
                    7 4 -3 	                        */

using System;
using System.Linq;

class AddingPolynomials
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] firstPolynomialCoefficients = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        int[] secondPolynomialCoefficients = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        int[] sum = AddPolynomials(firstPolynomialCoefficients, secondPolynomialCoefficients, length);

        Console.WriteLine(String.Join(" ", sum));
    }

    public static int[] AddPolynomials(int[] firstArray, int[] secondArray, int length)
    {
        int[] resultArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] + secondArray[i];
        }

        return resultArray;
    }

}