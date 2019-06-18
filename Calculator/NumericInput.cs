//-----------------------------------------------------------------------
// Author: N Ringham [P466939]
// Creation Date: 17/06/2019
// Version 1.0
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 
    /// </summary>
    class NumericInput
    {
        private const int digitMaximum = 16; 
        private string digitString = "0";
        private bool negative = false;
        private bool nonInteger = false;
        private bool clear = true;

        /// <summary>
        /// Used to convert the current numeric input value to a string for display
        /// </summary>
        /// <returns>a string representation the current numeric input value</returns>
        public override string ToString()
        {
            return negative ? "-" + digitString : digitString;
        }

        /// <summary>
        /// Clears the state of the numeric input, to be used to a new value
        /// </summary>
        public void PerformClear()
        {
            digitString = "0";
            negative = false;
            nonInteger = false;
            clear = true;
        }

        /// <summary>
        /// Whether the value represented is in the cleared state and has not been changed since
        /// </summary>
        /// <returns>whether the numeric input is in the cleared state</returns>
        public bool QueryIfClear()
        {
            return clear;
        }

        /// <summary>
        /// appends a digit to the numeric input
        /// </summary>
        /// <param name="digitCharacter">a digit [0-9]</param>
        /// <returns>whether the digit was appended</returns>
        public bool AddDigit(char digitCharacter)
        {
            //check that we've been passed a digit and only append the digit if there is room,
            //but don't include the decimal point in the digit length  being considered
            if (!Char.IsDigit(digitCharacter) || digitString.Length >= (nonInteger? digitMaximum+1 : digitMaximum))
                return false;

            clear = false;

            if (digitString.Length == 1 && digitString[0] == '0')
            {
                digitString = new string(digitCharacter, 1);
            }
            else
            {
                digitString = digitString + digitCharacter;
            }

            return true;
        }

        /// <summary>
        /// Adds a decimal point to the numeric input (if not already present)
        /// </summary>
        /// <returns>whether the decimal point was able to be added (will be false if there 
        /// was already a decimal point</returns>
        public bool AddDecimalPoint()
        {
            //if there is alread a decimal point we won't add another
            if (nonInteger)
                return false;
            digitString = digitString + '.';
            nonInteger = true;
            clear = false;
            return true;
        }

        /// <summary>
        /// change the sign of the numeric input value represented, a positive value will toggle
        /// to negative, and a negative to a positive
        /// </summary>
        public void ToggleSign()
        {
            clear = false;
            negative = !negative;
        }

        /// <summary>
        /// Convert the numeric input to a decimal number
        /// </summary>
        /// <returns>the decimal representation of the current value, may be 0 on failure but this
        /// should never occur in practice</returns>
        public decimal ToDecimal()
        {
            decimal.TryParse(digitString, out decimal intermediateResult);
            if (negative)
            {
                return Decimal.Negate(intermediateResult);
            }
            else
            {
                return intermediateResult;
            }
        }
    }
}
