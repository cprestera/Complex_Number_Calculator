//*****************************************************************
// Name: Cameron Prestera
// CS-3260 Section 001
// Assignment: Lab04
// Date: 9/20/2020

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will 
// receive a zero this project if I am found in violation of this policy
//******************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
