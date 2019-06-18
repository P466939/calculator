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
/// Provides algebraic functions
/// </summary>
public class AlgebraicFunctions
{
    /// <summary>
    /// Calculates the square root of a given value
    /// </summary>
    /// <param name="operand">The value to use for the calculation</param>
    /// <returns>the result of the calculation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation, such as when the supplied operand has a negative value</exception>
    public static decimal CalculateSquareRoot(decimal operand)
    {
        try
        {
            return (decimal)Math.Sqrt(decimal.ToDouble(operand));
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the cube root of a given value
    /// </summary>
    /// <param name="operand">The value to use for the calculation</param>
    /// <returns>the result of the calculation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateCubeRoot(decimal operand)
    {
        try
        {
            double d = Math.Pow(Math.Abs(decimal.ToDouble(operand)), 1.0 / 3.0);
            return Math.Sign(operand) < 0 ? (decimal)(-d) : (decimal)(+d);
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the multiplicative inverse of a given value
    /// </summary>
    /// <param name="operand">The value to use for the calculation</param>
    /// <returns>the result of the calculation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation, such as when the operand supplied is zero (or very close to it) </exception>
    public static decimal CalculateInverse(decimal operand)
    {
        try
        {
            return 1 / operand;
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }

    }
}