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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        if (n > 0 && n <= 100)
        {
            for (int i = 0; i < n; i++)
            {
                int space = n - i - 1;
                int symbol = i + 1;

                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                for (int y = 0; y < symbol; y++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
