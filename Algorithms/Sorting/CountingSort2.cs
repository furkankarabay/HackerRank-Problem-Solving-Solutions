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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        int maxVal = arr.Max();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> newArr = new List<int>();


        for (int i = 0; i < maxVal + 1; i++)
        {
            dict.Add(i, 0);
        }

        for (int i = 0; i < arr.Count; i++)
        {
            int val = dict[arr[i]];
            dict[arr[i]] = val + 1;
        }

        for (int i = 0; i < maxVal + 1; i++)
        {
            int val = dict[i];
            if (val > 0)
            {
                for (int j = 0; j < val; j++)
                {
                    newArr.Add(i);
                }
            }
        }

        return newArr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
