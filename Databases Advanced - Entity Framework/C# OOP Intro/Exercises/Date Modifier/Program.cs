﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var dateMod = new DateModifier();
        Console.WriteLine
            (dateMod.DaysDiff(Console.ReadLine(),Console.ReadLine()));
    }
}

