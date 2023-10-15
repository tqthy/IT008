using System;
using System.Collections;

namespace Bai2
{
    internal class Fraction : IComparable
    {
        private int numerator;
        private int denominator;
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Fraction otherFraction = obj as Fraction;
            return ((double)this.numerator / this.denominator).CompareTo((double)otherFraction.numerator/otherFraction.denominator);
        }
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero", nameof(denominator));
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Fraction(int num)
        {
            numerator = num;
            denominator = 1;
        }
        public static implicit operator Fraction(int num)
        {
            return new Fraction(num);
        }
        public static explicit operator double(Fraction fraction)
        {
            return (double)fraction.numerator / fraction.denominator;
        }
        public static void RationaliseDenominator(ref Fraction a, ref Fraction b)
        {
            int lcm = a.denominator * b.denominator / Computation.gcd(a.denominator, b.denominator);
            a.numerator *= lcm / a.denominator;
            b.numerator *= lcm / b.denominator;
            a.denominator = lcm;
            b.denominator = lcm;
        }

        public static void Simplifying(ref Fraction a)
        {
            int num = Computation.gcd(a.numerator, a.denominator);
            a.numerator /= num;
            a.denominator /= num;
        }

        public static Fraction operator+ (Fraction _a, Fraction _b)
        {
            Fraction a = new Fraction(_a.numerator, _a.denominator); Fraction b = new Fraction(_b.numerator, _b.denominator);
            Simplifying(ref a); Simplifying(ref b);
            RationaliseDenominator(ref a, ref b);
            Fraction res = new Fraction(a.numerator + b.numerator, a.denominator);
            Simplifying(ref res);
            return res;
        }
        public static Fraction operator- (Fraction _a, Fraction _b)
        {
            Fraction a = new Fraction(_a.numerator, _a.denominator); Fraction b = new Fraction(_b.numerator, _b.denominator);
            Simplifying(ref a); Simplifying(ref b);
            RationaliseDenominator(ref a, ref b);
            Fraction res = new Fraction(a.numerator - b.numerator, a.denominator);
            Simplifying(ref res);
            return res;
        }
        public static Fraction operator* (Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
            Simplifying(ref res);
            return res;
        }
        public static Fraction operator/ (Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
            Simplifying(ref res);
            return res;
        }
        public static bool operator == (Fraction _a, Fraction _b)
        {
            Fraction a = new Fraction(_a.numerator, _a.denominator); Fraction b = new Fraction(_b.numerator, _b.denominator);
            Simplifying(ref a); Simplifying(ref b);
            if (a.denominator == b.denominator && a.numerator == b.numerator) return true;
            return false;
        }
        public static bool operator != (Fraction _a, Fraction _b)
        {
            Fraction a = new Fraction(_a.numerator, _a.denominator); Fraction b = new Fraction(_b.numerator, _b.denominator);
            Simplifying(ref a); Simplifying(ref b);
            if (a.denominator != b.denominator || a.numerator != b.numerator) return true;
            return false;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Fraction)) return false;

            return this == (Fraction)obj;
        }
        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }
        public static bool operator > (Fraction a, Fraction b)
        {
            Simplifying(ref a); Simplifying(ref b);
            RationaliseDenominator(ref a, ref b);
            if (a.numerator > b.numerator) return true;
            return false;
        }
        public static bool operator < (Fraction a, Fraction b)
        {
            Simplifying(ref a); Simplifying(ref b);
            RationaliseDenominator(ref a, ref b);
            if (a.numerator < b.numerator) return true;
            return false;
        }
        public void Print()
        {
            Console.WriteLine(this.numerator + " / " + this.denominator);
        }
        static void Main(string[] args)
        {
            Fraction a = new Fraction(6, 9);
            Fraction b = new Fraction(5, 6);
            Fraction c = new Fraction(-6, 7);
            Fraction d = new Fraction(12, 14);
            Fraction ans = a + b;
            ans.Print(); a.Print(); b.Print();
            Console.WriteLine(c == d);
            ans = a + 5;
            ans.Print();
            ans = 10 - ans;
            ans.Print();
            Console.WriteLine((double)ans);
            ArrayList Fractions = new ArrayList();
            Console.WriteLine("Sorted: \n");
            Fractions.Add(a); Fractions.Add(b); Fractions.Add(c); Fractions.Add(d); Fractions.Add(d + 5);
            Fractions.Sort();
            foreach( Fraction i in Fractions )
            {
                i.Print();
            }
        }
    }
    static class Computation
    {
        public static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
    }
}