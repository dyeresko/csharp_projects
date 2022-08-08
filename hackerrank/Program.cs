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
        string[] subs = s.Split(":");
        int hour;
        if (Convert.ToString(s[^2]) + Convert.ToString(s[^1]) == "PM")
        {
            if (subs[0] != "12")
                subs[0] = Convert.ToString(Convert.ToInt16(subs[0]) + 12);
            subs[^1] = subs[^1].Split("PM")[0];
        }
        else
        {
            if (subs[0] == "12")
            {
                subs[0] = "00";
            }
            subs[^1] = subs[^1].Split("AM")[0];
        }


        System.Console.WriteLine(subs[^1]);

        return String.Join(":", subs);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}
