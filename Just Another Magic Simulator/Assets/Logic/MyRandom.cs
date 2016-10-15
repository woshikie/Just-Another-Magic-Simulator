using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MyRandom
{
    public static string RandomStringKey(int length)
    {
        const string dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string output = "";
        do{
            int index = UnityEngine.Random.Range(0, dictionary.Length - 1);
            output += dictionary[index];
        } while (--length != 0);
        return output;
    }
}
