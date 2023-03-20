using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StevenFractionalCalc
{
    class StevenFracNumcs
    {
        private int numerator;
        private int denominator;
        #region Constructor
        //Default Constructor
        public StevenFracNumcs()
        {
            Numerator = 0;
            Denominator = 1;
        }
        //Parameterize Constructor
        public StevenFracNumcs(int num, int denom)
        {
            Numerator = num;
            Denominator = denom;
        }
        //Copy Constructor
        public StevenFracNumcs(StevenFracNumcs fract)
        {
            Numerator = fract.Numerator;
            Denominator = fract.Denominator;
        }
        #endregion

        #region Properties
        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator
        {
            get => denominator;
            set
            {
                if(value !=0)
                {
                    denominator = value;
                }
                else
                {
                    throw new Exception("Denominator cannot be zero");
                }
            }
        }
        private int FindGcd(int num1, int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            int min = num1;
            if(num1 > num2)
            {
                min = num2;
            }
            int gcd = 1;
            for(int i =2; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                }
            }
            return gcd;
        }
        #endregion

        #region Methods
        public StevenFracNumcs Multiply(StevenFracNumcs fract2)
        {
            int num = this.Numerator * fract2.Numerator;
            int denom = this.Denominator * fract2.Denominator;
            int gcd = FindGcd(num, denom);
            StevenFracNumcs result = new StevenFracNumcs(num/gcd, denom/gcd);
            return result;
        }

        public StevenFracNumcs Multiply(int num)
        {
            StevenFracNumcs fract2 = new StevenFracNumcs(num, 1);
            return this.Multiply(fract2);
        }
        public StevenFracNumcs Add(StevenFracNumcs fract2)
        {
            int num = this.Numerator * fract2.Denominator + fract2.Numerator * this.Denominator;
            int denom = this.Denominator * fract2.Denominator;
            int gcd = FindGcd(num, denom);
            StevenFracNumcs result = new StevenFracNumcs(num / gcd, denom / gcd);
            return result;
        }

        public StevenFracNumcs Add(int num)
        {
            StevenFracNumcs fract2 = new StevenFracNumcs(num, 1);
            return this.Add(fract2);
        }
        public StevenFracNumcs Subs(StevenFracNumcs fract2)
        {
            int num = this.Numerator * fract2.Denominator - fract2.Numerator * this.Denominator;
            int denom = this.Denominator * fract2.Denominator;
            int gcd = FindGcd(num, denom);
            StevenFracNumcs result = new StevenFracNumcs(num / gcd, denom / gcd);
            return result;
        }

        public StevenFracNumcs Subs(int num)
        {
            StevenFracNumcs fract2 = new StevenFracNumcs(num, 1);
            return this.Subs(fract2);
        }
        public StevenFracNumcs Div(StevenFracNumcs fract2)
        {
            int num = this.Numerator * fract2.Denominator;
            int denom = this.Denominator * fract2.Numerator;
            int gcd = FindGcd(num, denom);
            StevenFracNumcs result = new StevenFracNumcs(num / gcd, denom / gcd);
            return result;
        }

        public StevenFracNumcs Div(int num)
        {
            StevenFracNumcs fract2 = new StevenFracNumcs(num, 1);
            return this.Div(fract2);
        }

        public int Convert()
        {
            int result = (int)Math.Round((double)this.Numerator / this.Denominator);
            return result;
        }
        public double Convert(int decimals)
        {
            double result = Math.Round((double)this.Numerator / this.Denominator, decimals);
            return result;
        }

        public bool IsEqual(StevenFracNumcs fract2)
        {
            bool result = false;
            double num1 = (double)this.Numerator / this.Denominator;
            double num2 = (double)fract2.Numerator / fract2.Denominator;
            if(num1 == num2)
            {
                result = true;
            }
            return result;
        }
        public bool IsEqual(int num)
        {
            StevenFracNumcs fract2 = new StevenFracNumcs(num, 1);
            return this.IsEqual(fract2);
        }

        public static StevenFracNumcs operator * (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return fract1.Multiply(fract2);
        }

        public static StevenFracNumcs operator + (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return fract1.Add(fract2);
        }

        public static StevenFracNumcs operator / (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return fract1.Div(fract2);
        }

        public static StevenFracNumcs operator - (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return fract1.Subs(fract2);
        }

        public static bool operator == (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return fract1.IsEqual(fract2);
        }

        public static bool operator != (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return !fract1.IsEqual(fract2);
        }

        public static bool operator > (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            bool result = false;
            double num1 = (double)fract1.Numerator / fract1.Denominator;
            double num2 = (double)fract2.Numerator / fract2.Denominator;
            if (num1 > num2)
            {
                result = true;
            }
            return result;
        }

        public static bool operator < (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return !(fract1 >= fract2);
        }

        public static bool operator >= (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            bool result = false;
            double num1 = (double)fract1.Numerator / fract1.Denominator;
            double num2 = (double)fract2.Numerator / fract2.Denominator;
            if (num1 >= num2)
            {
                result = true;
            }
            return result;
        }

        public static bool operator <= (StevenFracNumcs fract1, StevenFracNumcs fract2)
        {
            return !(fract1 > fract2);
        }

        public static StevenFracNumcs operator-(StevenFracNumcs fract)
        {
            StevenFracNumcs result = new StevenFracNumcs(-fract.Numerator, fract.Denominator);
            return result;
        }
        #endregion

    }
}
