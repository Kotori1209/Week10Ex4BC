/* Programmer: Bozhou Chen
 * Group Number: Group #1
 * Group Members: Bozhou C, Charles B, Cyrus C, Jacob B, Tyler D
 * Date: 10/29/2020
 * Purpose: A class that reads user's input value
 * Class: CITP 180
 * Assignment: Chapter 8 - Programming Excercise 4
 */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Week10Ex4BC
{
    class MailingLabel
    {
        private string fullName;
        private string birthDate;
        private int subMonth;
        private int zipCode;

        // Default Constructor
        public MailingLabel()
        {

        }

        // Constructor with several parameters
        public MailingLabel(string fullN, string birthD, int subM, int zipC)
        {
            fullN = fullName;
            birthD = birthDate;
            subM = subMonth;
            zipC = zipCode;
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
        public int SubMonth
        {
            get
            {
                return subMonth;
            }
            set
            {
                subMonth = value;
            }
        }
        public int ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

    }

}
