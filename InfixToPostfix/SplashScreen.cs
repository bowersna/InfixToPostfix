/*
 * Class : CSCI 2210-201  --Data Structures--
 * File Name : SplashScreen.cs
 * 
 * Purpose	: Create a borderless and transparent form that 
 *            contains a tick timer, once the timer expires the
 *            screen closes and the main form is loaded. This 
 *            form displays the program title and version along 
 *            with a nice looking image.
 *            
 *            **The information was gathered from the AssemblyInfo.cs
 *              file, this file was accessed by the ApplicationInfo class
 *              I created within this file.
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
using System.Reflection;
using System.Windows.Forms;

namespace InfixToPostfix
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        //close the splash screen when tick timer expires
        private void TickTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        //display the version number via the assemblyinfo.cs file
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.TitleLabel.Text = ApplicationInfo.Title;
            this.LabelProductVersion.Text = "Version: " + ApplicationInfo.Version;
        }

    }

    //use this class to get the version from assemblyinfo.cs
    static public class ApplicationInfo
    {
        public static Version Version { get { return Assembly.GetCallingAssembly().GetName().Version; } }

        public static string Title
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title.Length > 0) return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
    }
}
