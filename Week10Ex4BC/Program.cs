/* Programmer: Bozhou Chen
 * Group Number: Group #1
 * Group Members: Bozhou C, Charles B, Cyrus C, Jacob B, Tyler D
 * Date: 10/29/2020
 * Purpose: Creates a customer code to be placed on a mailing label for a magazine.
 * Class: CITP 180
 * Assignment: Chapter 8 - Programming Excercise 4
 */

using System;
using static System.Console;

namespace Week10Ex4BC
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName, subMonth;
            int birth2Year, subscriptionMonth, zip2Code, nameLength;
            MailingLabel mailingLabel = new MailingLabel();
            return3:
            fullName = PromptFullName(mailingLabel.FullName);
            bool fullNameSpace = fullName.Contains(' ');
            if (fullNameSpace == false)
            {
                WriteLine("You didn't include space between your name. Try again.");
                goto return3;
            }
            string[] names = fullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];
            nameLength = firstName.Length + lastName.Length;
            birth2Year = PromptBirthDate(mailingLabel.BirthDate);
            subscriptionMonth = PromptSubscriptionMonth(mailingLabel.SubMonth);
            subMonth = ConvertNumToMonth(subscriptionMonth);
            zip2Code = PromptZipCode(mailingLabel.ZipCode);
            MailingCodeOutput(lastName, birth2Year, nameLength, subMonth, zip2Code);
            ReadKey();
        }  // End of Main()

        public static string PromptFullName(string fullN)  // propmt the user's full name
        {
            Write("Please enter your full name (with a space between): ");
            fullN = ReadLine();
            WriteLine();
            return fullN;
        }

        public static int PromptBirthDate(string birthD)  // prompt the user's birth date
        {
            int yearBorn;
            return0:
            Write("Please enter your birth date\n(format:MM/DD/YYYY): ");
            birthD = ReadLine();
            string lastTwo = birthD.Substring(birthD.Length - 2);
            if (int.TryParse(lastTwo, out yearBorn) == false)
            {
                WriteLine("You didn't follow the format. Please enter again.\n");
                goto return0;
            }
            WriteLine();
            return yearBorn;
        }
        public static int PromptSubscriptionMonth(int subM)  // prompt the user's subscription month
        {
            string inValue;
            return1:
            WriteLine("During which month did you purchase the subscription?");
            Write("Enter the number of the month: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out subM) == false)
            {
                WriteLine("Invalid input. Please enter again.\n");
                goto return1;
            }
            WriteLine();
            return subM;
        }

        public static string ConvertNumToMonth(int subM)
            // convert the subscription month number to corresponding month
        {
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May",
                    "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            return month[subM-1];
        }

        public static int PromptZipCode(int zipC)
            // prompt the zip code from the user and return the last two digits of the zip code
        {
            string inValue;
            return2:
            Write("Please enter your zip code: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out zipC) == false)
            {
                WriteLine("Invalid input. Zip codes should be entered in number. Try again.\n");
                goto return2;
            }
            WriteLine();
            int lastTwoDigits = zipC % 100;
            return lastTwoDigits;
        }

        public static void MailingCodeOutput(string lastN, int birth2Y, int nameL,
                                               string month, int zip2C)
            // Final output
        {
            WriteLine("Your customer mailing code is: " + lastN + birth2Y.ToString() +
                       nameL.ToString() + month + zip2C.ToString());
            return;
        }
    }
}
