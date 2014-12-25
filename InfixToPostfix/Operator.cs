/*
 * Class : CSCI 2210-201  --Data Structures--
 * File Name : Operator.cs
 * 
 * Purpose	: Create operator objects that have a precedence
 *            over a different operator. (=,(,),*,/,+,-)
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixToPostfix
{
    class Operator
    {
        public string Op { get; set; }
        public int Precedence { get; set; }

        public Operator()
        {
            //default operator values
            Op = "";
            Precedence = -1;
        }
        //0 is lowest precedence, then 1, then 2
        public Operator(string op)
        {
            this.Op = op;
            if (op.ToString().Equals("+") || op.ToString().Equals("-"))
            {
                this.Precedence = 0;
            }
            else if (op.ToString().Equals("*") || op.ToString().Equals("/"))
            {
                this.Precedence = 1;
            }
            else if (op.ToString().Equals("=") || op.ToString().Equals("(") ||
                op.ToString().Equals(")"))
            {
                this.Precedence = 2;
            }
        }
        //Operator methods for allowing the use of greater than and less than
        //when dealing with an operators Precedence
        public static int operator< (Operator Left, Operator Right)
        {
            return Left.Precedence.CompareTo(Right.Precedence);
        }
        public static int operator> (Operator Left, Operator Right)
        {
            return Left.Precedence.CompareTo(Right.Precedence);
        }
    }
}
