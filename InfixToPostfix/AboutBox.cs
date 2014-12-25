/*
 * Class : CSCI 2210-201  --Data Structures--
 * File Name : AboutBox.cs
 * 
 * Purpose	: Create a form that displays more information about
 *            the program such as Title, Company, Copyright, Description,
 *            and Version. There is also a Picture Box with an apporpriate
 *            image displayed. The information is filled from data fromt the
 *            AssemblyInfo.cs file. I also created ApplicationInfo class within 
 *            this file as well to access this data.         
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
    public partial class AboutBox : Form
    {
        //variables used to store information from assemblyinfo.cs
        static string productDescription, companyName, productName, copyright, title;
        Version version;

        //constructor for my aboutbox
        public AboutBox()
        {
            InitializeComponent();

            //get information from assemblyinfo.cs for display
            title = ApplicationInfo.Title;
            copyright = ApplicationInfo.CopyrightHolder;
            productName = ApplicationInfo.ProductName;
            version = ApplicationInfo.Version;
            companyName = ApplicationInfo.CompanyName;
            productDescription = ApplicationInfo.Description;

            //display different information from assemblyinfo.c  
            this.Text = String.Format("About {0}", title);
            this.LabelAuthor.Text = copyright;
            this.LabelCompany.Text = companyName;
            this.LabelHeader.Text = productName;
            this.LabelVersion.Text = String.Format("Version {0}", version);
            this.DescriptionTextBox.Text = productDescription;
        }


        /// <summary>
        //  Methods are used to grab information from assemblyinfo.cs
        /// </summary>
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

            public static string ProductName
            {
                get
                {
                    object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                    return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
                }
            }

            public static string Description
            {
                get
                {
                    object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                    return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
                }
            }

            public static string CopyrightHolder
            {
                get
                {
                    object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                    return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
                }
            }

            public static string CompanyName
            {
                get
                {
                    object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                    return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
                }
            }

        }
    }
}
