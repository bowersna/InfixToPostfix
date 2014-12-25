/*
 * Class : CSCI 2210-201  --Data Structures--
 * File Name : Driver.cs
 * 
 * Purpose	: The auto generated driver for the Windows Form
 *            Application. Run the splash screen, then the main
 *            form.
 *            
 *
 * Author:Nick Bowers
 * E-Mail: BOWERSNA@goldmail.etsu.edu
 * 
 * Create Date    : Tuesday, October 29, 2013
 * Last Modified  : Thursday, October 31, 2013
 * Modified By	: Nick Bowers
 */
using System;
using System.Windows.Forms;

namespace InfixToPostfix
{
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
            Application.Run(new MainForm());
        }
    }
}
