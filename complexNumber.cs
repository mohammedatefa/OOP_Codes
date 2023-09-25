using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_six_oop
{
    public class ComplexNumber
    {
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public ComplexNumber(double real) : this(real, 0)
        {
        }

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(real * real + imaginary * imaginary);
        }

        public static bool operator >=(ComplexNumber a, ComplexNumber b)
        {
            return a.GetMagnitude() >= b.GetMagnitude();
        }

        public static bool operator <=(ComplexNumber a, ComplexNumber b)
        {
            return a.GetMagnitude() <= b.GetMagnitude();
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static ComplexNumber operator ++(ComplexNumber a)
        {
            return new ComplexNumber(a.Real + 1, a.Imaginary + 1);
        }

        public static implicit operator ComplexNumber(double value)
        {
            return new ComplexNumber(value);
        }

        public static explicit operator double(ComplexNumber complex)
        {

            return complex.Real;
        }

        public override bool Equals(object obj)
        {
            if (GetType() != obj.GetType())
                return false;
            else
            {
                ComplexNumber other = (ComplexNumber)obj;
                return real == other.real && imaginary == other.imaginary;
            }
        }

        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
}
