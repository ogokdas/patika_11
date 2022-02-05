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
    public static void Main(string[] args)
    {
        int[] sayiDizisi = { 1, 3, 4, 9, 8, 7 };
        Array.Resize<int>(ref sayiDizisi, 8);
        Array.Sort(sayiDizisi);
        Array.Reverse(sayiDizisi);
        Array.Clear(sayiDizisi,2,2);
        Array.IndexOf(sayiDizisi, 5);

    }
}
