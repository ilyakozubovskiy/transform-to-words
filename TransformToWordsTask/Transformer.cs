using System;
using System.Globalization;
using System.Text;

#pragma warning disable CA1822

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (double.IsNegativeInfinity(number))
            {
                return "Negative Infinity";
            }

            if (double.IsPositiveInfinity(number))
            {
                return "Positive Infinity";
            }

            if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }

            StringBuilder res = new StringBuilder();
            var stringNumber = number.ToString(CultureInfo.InvariantCulture);

            if (double.IsNegative(number))
            {
                res.Append("Minus");
            }

            for (int i = 0; i < stringNumber.Length; i++)
            {
                switch (stringNumber[i] - '0')
                {
                    case 0:
                        res.Append(" zero");
                        break;
                    case 1:
                        res.Append(" one");
                        break;
                    case 2:
                        res.Append(" two");
                        break;
                    case 3:
                        res.Append(" three");
                        break;
                    case 4:
                        res.Append(" four");
                        break;
                    case 5:
                        res.Append(" five");
                        break;
                    case 6:
                        res.Append(" six");
                        break;
                    case 7:
                        res.Append(" seven");
                        break;
                    case 8:
                        res.Append(" eight");
                        break;
                    case 9:
                        res.Append(" nine");
                        break;
                    case -2:
                        res.Append(" point");
                        break;
                    case -5:
                        res.Append(" plus");
                        break;
                    case 21:
                        res.Append(" E");
                        break;
                }
            }
            
            char[] result = res.ToString().Trim().ToCharArray();
            result[0] = char.ToUpper(result[0], CultureInfo.InvariantCulture);

            return new string(result);
        }
    }
}
