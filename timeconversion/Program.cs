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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var result = "";
        var values = s.Split(':');
        var isAM = values[2].Contains("AM") ? true : false;
        if (!isAM)
        {
            var hours = 0;
            if (Convert.ToInt32(values[0]) != 12)
                hours = Convert.ToInt32(values[0]) + 12;
            else
                hours = Convert.ToInt32(values[0]);
            result = $"{hours}:{values[1]}:{values[2].Remove(2, 2)}";
        }
        else
        {
            var hours = Convert.ToInt32(values[0]);
            if (hours == 12)
                hours = 00;
            var strhours = hours < 10 ? "0"+hours : hours.ToString();
            result = $"{strhours}:{values[1]}:{values[2].Remove(2, 2)}";
        }
        Console.WriteLine(result);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}
