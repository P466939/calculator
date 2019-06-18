//-----------------------------------------------------------------------
// Author: N Ringham [P466939]
// Creation Date: 11/06/2019
// Version 1.0
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides arithmetic functions
/// </summary>
public class ArithmeticFunctions
{
    /// <summary>
    /// Calculates the sum of two operands
    /// </summary>
    /// <param name="firstOperand">the first value to be summed</param>
    /// <param name="secondOperand">the second value to be summed</param>
    /// <returns>the result of the addition/sum operation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateAddition(decimal firstOperand, decimal secondOperand)
    {
        try
        {
            return firstOperand + secondOperand;
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the difference of two operands
    /// </summary>
    /// <param name="firstOperand">the first value to be used</param>
    /// <param name="secondOperand">the value to be subtracted from the first value</param>
    /// <returns>the difference / result of the subtraction of the values</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateSubtraction(decimal firstOperand, decimal secondOperand)
    {
        try
        {
            return firstOperand - secondOperand;
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the product of two operands
    /// </summary>
    /// <param name="firstOperand">the first value to be multiplied</param>
    /// <param name="secondOperand">The second value to be multiplied</param>
    /// <returns>the result of the multiplication</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateMultiplication(decimal firstOperand, decimal secondOperand)
    {
        try
        {
            return firstOperand * secondOperand;
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the quotient of two operands
    /// </summary>
    /// <param name="firstOperand">the dividend</param>
    /// <param name="secondOperand">the divisor</param>
    /// <returns>the result of the division operation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateDivision(decimal firstOperand, decimal secondOperand)
    {
        try
        {
            return firstOperand / secondOperand;
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }
}