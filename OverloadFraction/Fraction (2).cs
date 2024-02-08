using System;

namespace OverloadFraction
{
    public class Fraction
    {
        public int N { get; }
        public int D { get; }

        public Fraction(int n, int d)
        {
            Semplifica(ref n, ref d);

            N = n;
            D = d;
        }

        private void Semplifica(ref int n, ref int d)
        {
            int mcd = CalcolaMcd(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int CalcolaMcd(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        public Fraction Somma(Fraction other)
        {
            return new Fraction(this.N * other.D + this.D * other.N, this.D * other.D);
        }

        public Fraction Sottrai(Fraction other)
        {
            return new Fraction(this.N * other.D - this.D * other.N, this.D * other.D);
        }

        public Fraction Moltiplica(Fraction other)
        {
            return new Fraction(this.N * other.N, this.D * other.D);
        }

        public Fraction Dividi(Fraction other)
        {
            return new Fraction(this.N * other.D, this.D * other.N);
        }


        public override string ToString()
        {
            return $"{N}/{D}";
        }


        public static Fraction Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public static bool TryParse(string s, out Fraction result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public static Fraction operator +(Fraction f, Fraction g)
        {

            Fraction x = f.Somma(g);
            return x;
        }

    }
}
