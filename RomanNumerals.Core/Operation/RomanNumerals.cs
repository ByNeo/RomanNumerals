using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Core.Operation
{
    public class RomanNumerals
    {
        /// <summary>
        /// Checks for situations that prevent translation into Roman numerals.
        /// </summary>
        /// <param name="number">The number to be converted to Roman numerals.</param>
        private void Validate(int number)
        {
            if (number < 0)
                throw new Exception("The number can not be less than zero.");
        }


        /// <summary>
        /// The method of converting to Roman numerals.
        /// </summary>
        /// <param name="number">The number to be converted to Roman numerals.</param>
        /// <returns></returns>
        public string Parse(int number)
        {
            Validate(number);


            string romanNum = "";

            var mRoman = "";
            while (number >= 1000)
            {
                mRoman += "M";
                number -= 1000;
            }

            var dRoman = "";
            while (number >= 500)
            {
                dRoman += "D";
                number -= 500;
            }
            if (number % 500 >= 400 && number % 500 < 500)
            {
                number -= 400;
                dRoman = "C" + dRoman + "D";
            }

            var cRoman = "";
            while (number >= 100)
            {
                cRoman += "C";
                number -= 100;
            }

            var lRoman = "";
            while (number >= 50)
            {
                lRoman += "L";
                number -= 50;
            }
            if (number % 50 >= 40 && number % 50 < 50)
            {
                number -= 40;
                lRoman = "X" + lRoman + "L";
            }

            var xRoman = "";
            while (number >= 10)
            {
                xRoman += "X";
                number -= 10;
            }

            var five = "";
            while (number >= 5)
            {
                five += "V";
                number -= 5;
            }

            if (number % 5 == 4)
            {
                number -= 4;
                five = "I" + five + "V";
            }
            romanNum += mRoman + dRoman + cRoman + lRoman + xRoman + five;

            romanNum = romanNum.Replace("VV", "X");
            romanNum = romanNum.Replace("XXXXX", "L");
            romanNum = romanNum.Replace("LL", "C");
            romanNum = romanNum.Replace("CCCCC", "D");
            romanNum = romanNum.Replace("DD", "M");

            //romanNum = romanNum.Replace("XXXX", "XL");
            //romanNum = romanNum.Replace("CCCC", "CD");


            for (int i = 1; i <= number; i++)
            {
                romanNum += "I";
            }


            return romanNum;
        }
    }
}
