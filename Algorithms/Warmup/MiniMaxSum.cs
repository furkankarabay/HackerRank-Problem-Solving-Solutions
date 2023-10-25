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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sumMin = 0;
        long sumMax = 0;
        int minNumberIndex = arr.IndexOf(arr.Min());
        for (int i = 0; i < arr.Count(); i++)
        {
            if (i == minNumberIndex)
                continue;

            sumMin += arr[i];
        }
        int maxNumberIndex = arr.IndexOf(arr.Max());


        for (int i = 0; i < arr.Count(); i++)
        {
            if (i == maxNumberIndex)
                continue;

            sumMax += arr[i];
        }
        Console.Write(sumMax + " " + sumMin);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
