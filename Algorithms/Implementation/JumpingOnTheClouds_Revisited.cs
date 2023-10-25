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

class Solution
{

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c, int k)
    {

        int n = c.Count();
        int currentCloudIndex = 0;
        int totalEnergyCost = 0;
        bool completed = false;

        int i = 0;
        while (!completed)
        {
            currentCloudIndex += k;

            if (currentCloudIndex >= n)
                currentCloudIndex = currentCloudIndex % (n);

            totalEnergyCost++;

            if (c[currentCloudIndex] == 1)
                totalEnergyCost += 2;

            if (currentCloudIndex == 0)
                completed = true;

            i++;
        }

        return 100 - totalEnergyCost;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
