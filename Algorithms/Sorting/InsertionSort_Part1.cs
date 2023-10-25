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
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        int lastIndexVal = arr[arr.Count - 1];
        for (int i = arr.Count - 2; i >= 0; i--)
        {
            if (arr[i] > lastIndexVal)
            {
                if (i == 0)
                {
                    arr[i + 1] = arr[i];
                    arr.ForEach(i => Console.Write("{0} ", i));
                    Console.WriteLine();
                    arr[i] = lastIndexVal;
                }
                else
                    arr[i + 1] = arr[i];
            }
            else
            {
                arr[i + 1] = lastIndexVal;
                arr.ForEach(i => Console.Write("{0} ", i));
                break;
            }

            arr.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
