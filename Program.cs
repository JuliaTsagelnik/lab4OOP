﻿using System;
using System.Windows.Forms;

namespace CircleMovementApp
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CircleForm());
        }
    }
}