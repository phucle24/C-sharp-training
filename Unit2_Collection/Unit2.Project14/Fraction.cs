using System;
using System.Collections.Generic;
using System.Text;

namespace Unit2.Project14
{
    public class Fraction
    {
        private int _numerator, _denominator;
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get
            {
                return _denominator == 0 ? 1 : _denominator;
            }
            set
            {
                if (value != 0)
                {
                    _denominator = value;
                }
                else
                {
                    throw new InvalidOperationException("Mau so khong duoc gia tri bang 0");
                }

            }
        }

        /// <summary>
        /// Tính tổng 2 phân số
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int resultNumerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator;
            int resultDenominator = fraction1.Denominator * fraction2.Denominator;
            return new Fraction(resultNumerator, resultDenominator);
        }

        /// <summary>
        /// Hiệu 2 phân số
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int resultNumerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator;
            int resultDenominator = fraction1.Denominator * fraction2.Denominator;
            return new Fraction(resultNumerator, resultDenominator);
        }

        /// <summary>
        /// Định dạng kiểu phân số
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
