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
     * Complete the 'insertionSort2' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort2(int n, List<int> arr)
    {
        for (int i = 1; i < arr.Count; i++)
        {
            int newPosIndex = i;

            for (int j = i - 1; j >= 0; j--)
            {
                if (arr[i] > arr[j])
                    continue;
                else
                {
                    newPosIndex = j;
                }
            }

            if (newPosIndex != i)
            {
                int temp = arr[i];
                arr.Remove(temp);
                arr.Insert(newPosIndex, temp);
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

        Result.insertionSort2(n, arr);
    }
}
