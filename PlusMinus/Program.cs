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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float itemCount = arr.Count;
        float positveCount = 0;
        float negativeCount = 0;
        float zeroCount = 0;
        foreach (var item in arr)
        {
            if (item > 0)
                positveCount++;
            else if (item < 0)
                negativeCount++;
            else if (item == 0)
                zeroCount++;
        }
        if (positveCount > 0)
            Console.WriteLine((positveCount / itemCount).ToString("0.000000"));
        else
            Console.WriteLine(0.ToString("0.000000"));

        if (negativeCount > 0)
            Console.WriteLine((negativeCount / itemCount).ToString("0.000000"));
        else
            Console.WriteLine(0.ToString("0.000000"));

        if (zeroCount > 0)
            Console.WriteLine((zeroCount / itemCount).ToString("0.000000"));
        else
            Console.WriteLine(0.ToString("0.000000"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Add the number of arrays rows you want");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
