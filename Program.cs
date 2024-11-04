// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Chapter 02, Assignment 01)
// Description of the Program: This program will display the type of card that is clicked on



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker_large_Ahmed_Benyusuf
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PictureIdentifier());
        }
    }
}
