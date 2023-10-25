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
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    public static int beautifulDays(int i, int j, int k)
    {
        int wholeNumberCount = 0;
        int startingDayNumber = i;
        int endingDayNumber = j;
        for (int x = startingDayNumber; x <= endingDayNumber; x++)
        {
            int reverseNumber = ReverseInt(x);
            if (Math.Abs((x - reverseNumber)) % k == 0)
            {
                wholeNumberCount++;
            }
        }

        return wholeNumberCount;
    }

    public static int ReverseInt(int number)
    {
        int reversedNumber = 0;

        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number = number / 10;
        }

        return reversedNumber;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
