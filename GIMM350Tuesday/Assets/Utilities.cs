using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;

public static class Utilities
{
    public static string ProcessText(string txt)
    {
        /*
        //return the word string if the user enters a string
        //return the word number if the user enters a number including decimals --> doubles and floats

        string[] valueList = txt.Split(' ');
        int stringTotal = 0;
        int numberTotal = 0;

        for (int i = 0; i < valueList.Length; i++)
        {
            if (TestIfNum(valueList[i]))
            {
                numberTotal++;
            }
            else
            {
                stringTotal++;
            }
        }
        string outText = "String(s): " + stringTotal + "\nNumber(s): " + numberTotal;
        return outText;
        */

        string[] stringList = txt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] valueList = new int[stringList.Length];
        double total = 0;
        double average = 0;

        if (stringList.Length > 0)
        {
            for (int i = 0; i < stringList.Length; i++)
            {
                valueList[i] = stringList[i].Length;
            }
            for (int i = 0; i < valueList.Length; i++)
            {
                total += valueList[i];
            }
            average = total / valueList.Length;
        }

        return average.ToString();
    }

    private static bool TestIfNum(string txt)
    {
        bool isNum = false;
        float num;
        if (float.TryParse(txt, out num))
        {
            isNum = true;
        }

        return isNum;
    }
}
