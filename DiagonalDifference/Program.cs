using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int firstDiagnoalValue = 0;
        int secondDiagonalValue = 0;
        int row = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                // Adding the first diagonal
                if (i == j)
                    firstDiagnoalValue += arr[i][j];
                if (row == i && j == (arr.Count - 1))
                {
                    secondDiagonalValue += arr[i][j - i];
                }
            }
            row++;
        }
        return Math.Abs(firstDiagnoalValue - secondDiagonalValue);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        Console.WriteLine("Enter the array length");
        int n = Convert.ToInt32(Console.ReadLine());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter the row number {i} value");

            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
