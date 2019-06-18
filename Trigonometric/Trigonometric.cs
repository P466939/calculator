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
/// Provides trigonometric functions
/// </summary>
public class TrigonometricFunctions
{
    /// <summary>
    /// The maximum magnitude the Tangent function can return before reporting an error
    /// </summary>
    private static readonly double maximumTangentMagnitude = 10_000_000_000;

    /// <summary>
    /// Used to convert an angle in degress into radians
    /// </summary>
    /// <param name="degrees">the angle in degrees to convert</param>
    /// <returns>the converted angle in radians</returns>
    private static double ConvertDegreesToRadians(decimal degrees)
    {
        return decimal.ToDouble(degrees) * (Math.PI / 180.0);
    }

    /// <summary>
    /// Calculates the sine on a given angle in degrees
    /// </summary>
    /// <param name="operandInDegrees">the angle in degrees</param>
    /// <returns>the result of the calculation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateSine(decimal operandInDegrees)
    {
        try
        {
            return (decimal)Math.Sin(ConvertDegreesToRadians(operandInDegrees));
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the cosine of a given angle in degrees
    /// </summary>
    /// <param name="operandInDegrees">the angle in degrees</param>
    /// <returns>the result of the calculation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation</exception>
    public static decimal CalculateCosine(decimal operandInDegrees)
    {
        try
        {
            return (decimal)Math.Cos(ConvertDegreesToRadians(operandInDegrees));
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }

    /// <summary>
    /// Calculates the tangent of a given angle in degrees
    /// </summary>
    /// <param name="operandInDegrees">the angle in degrees</param>
    /// <returns>the result of the calculation</returns>
    /// <exception cref="ArithmeticException">Throws when there was an error preforming
    /// the calculation, this is expected for angles +/- 90 degrees, values extremely close
    /// to this, and equivalents (eg 90+360 degrees, 90+720 degrees...)</exception>
    public static decimal CalculateTangent(decimal operandInDegrees)
    {
        try
        {
            double tangentValue = Math.Tan(ConvertDegreesToRadians(operandInDegrees));

            //I don't like this, but the assessment wants this function to error when the tangent is stupidly large
            //in magnitude (floating point infinities are considered as stupidly large, but in practice I often just
            //get really big numbers presumably due to floating point inaccuries)
            if (Math.Abs(tangentValue) > maximumTangentMagnitude)
                throw new ArithmeticException("Tangent out of range");

            return (decimal)tangentValue;
        }
        catch (Exception exception)
        {
            throw new ArithmeticException(exception.Message);
        }
    }
}