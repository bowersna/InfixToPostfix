/*
 * Class : CSCI 2210-201  --Data Structures--
 * File Name : MainForm.cs
 * 
 * Purpose	: Create a main form window that will allow the user to
 *            input an infix expression for it to be converted and 
 *            displayed in its postfix form in two different text boxes.
 *            The user can also input a list of infix expressions from
 *            a .txt file and they will be displayed in a list box, when
 *            the user selects one of them, they can convert them to postfix
 *            as well.
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
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace InfixToPostfix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear the textboxes
            this.PostfixTextbox.Clear();
            this.InfixTextbox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //exit the form
            this.Close();
        }

        private void GeneratePostfixButton_Click(object sender, EventArgs e)
        {
            string PostFixExpression,
            InFixExpression = this.InfixTextbox.Text.ToString();
            //generate the postfix of the current infix expression in the text box
            Convert(ref InFixExpression, out PostFixExpression);
            this.InfixTextbox.Text = InFixExpression;
            this.PostfixTextbox.Text = PostFixExpression;
        }

        private void inputInfixDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String FileName;

            //input a data file from user's computer
            //create a new open file dialog object
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Title = "Select (.txt) File To Read From";
            //filter out any other files besides .txt
            dlg.Filter = "text files|*txt";
            if (DialogResult.Cancel != dlg.ShowDialog())
            {
                FileName = dlg.FileName;
            }
            //read the file taken in
            StreamReader Read = null;
            FileName = dlg.FileName;
            //try to read the file and populate the list box
            try
            {
                //clear list box before adding new file
                ListBox.Items.Clear();
                //read file, then populate the list with each line
                Read = new StreamReader(FileName);
                while (Read.Peek() != -1)
                {
                    ListBox.Items.Add(Read.ReadLine());
                }
            }
            //catch an exception if the file wasnt read correctly
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + "\n" + ex.Message + "\n" + ex.StackTrace, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                //if the Read isn't null, then close 
                if (Read != null)
                {
                    Read.Close();
                }
            }
            //update the list box
            ListBox.Update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close and exit the form
            this.Close();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the item is selected in the list, display it in the Infix textbox
            InfixTextbox.Text = (String)ListBox.SelectedItem;
            PostfixTextbox.Clear();
        }

        private void aboutInfixToPostfixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the about box
            AboutBox abBox = new AboutBox();
            if (DialogResult.Cancel != abBox.ShowDialog())
            {

            }
        }

        /// <summary>
        /// Convernts an infix string to a postfix string
        /// </summary>
        /// <param name="InFix">string of infix expression</param>
        /// <param name="ExPostFix">postfix string returned</param>
        /// <returns>postfix expression</returns>
        static public bool Convert(ref string InFix, out string ExPostFix)
        {
            int priority = 0;
            char op;
            ExPostFix = "";
            Stack<char> OpStack = new Stack<char>();

            //seach each character at a time in the string
            for (int i = 0; i < InFix.Length; i++)
            {
                op = InFix[i];
                //if we found an operator 
                if (op.ToString().Equals("+") || op.ToString().Equals("-") ||
                    op.ToString().Equals("*") || op.ToString().Equals("/") ||
                    op.ToString().Equals("=") || op.ToString().Equals("(") ||
                    op.ToString().Equals(")"))
                {
                    //check the precedence of the operator
                    op = InFix[i];
                    //check to see if the stack is empty
                    if (OpStack.Count <= 0)
                    {
                        OpStack.Push(op);
                    }
                    //stack not empty
                    else
                    {
                        if (OpStack.Peek() == '=')
                        {
                            //highest priority
                            priority = 3;
                        }
                        //character is an open parenthese
                        //push the operator onto the stack
                        else if (op == '(')
                        {
                            //high priority push the character onto stack
                            priority = 3;
                        }
                        //if the character is a close parenthese
                        //pop off the stack and add to output string
                        //until we find another open parenthese
                        else if (op == ')')
                        {
                            try
                            {
                                do
                                {
                                    ExPostFix += " ";
                                    ExPostFix += OpStack.Pop() + " ";
                                }
                                while (OpStack.Peek() != '(');
                            }
                            catch (Exception e)
                            {
                                ExPostFix = "Error***   Unpaired Closing Parenthesis ";
                            }
                            //set priority to 1
                            priority = 2;
                        }
                        //set priority for * and /
                        else if (OpStack.Peek() == '*' || OpStack.Peek() == '/')
                        {
                            priority = 2;
                        }
                        //set priority for * and /
                        else if (op == '*' || op == '/')
                        {
                            priority = 1;
                        }
                        //set priority for + and -
                        else
                        {
                            priority = 0;
                        }

                        //seperate if statements 

                        if (priority == 3)
                        {
                            //push the character onto the stack
                            OpStack.Push(op);
                        }
                        else if (priority == 2)
                        {
                            try
                            {
                                //if the top of the stack is a open parentheses, just pop the stack
                                if (OpStack.Peek() == '(')
                                {
                                    OpStack.Pop();
                                }
                                //pop off the stack and add to output
                                //decrement index
                                else
                                {
                                    ExPostFix += " ";
                                    ExPostFix += OpStack.Pop() + " ";
                                    i--;
                                }
                            }
                            catch (Exception e)
                            {
                                ExPostFix = "Error***   Unpaired Closing Parenthesis ";
                            }
                        }
                        else
                        {
                            //push the new operator
                            OpStack.Push(op);
                        }
                    }
                }
                else
                {
                    //add non operator characters to output string
                    ExPostFix += InFix[i];
                }
            }
            //end of string, pop the rest of the stack to the output string
            ExPostFix += " ";
            int length = OpStack.Count;
            for (int r = 0; r < length; r++)
            {
                op = OpStack.Pop();
                ExPostFix += op.ToString() + " ";
            }
            //if the sentence contains an opening parenthesis, there was an error
            if(ExPostFix.Contains("(") == true)
            {
                ExPostFix = "Error***   Unpaired Open Parenthesis ";
            }
            //return true if the method found postfix form
            return true;
        }
    }
}