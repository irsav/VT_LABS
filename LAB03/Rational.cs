namespace LAB03
{
    public class Rational
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }

        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                denominator = value;
            }
        }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");
            this.numerator = numerator;
            this.denominator = denominator;
            Normalize();
            Reduce();
        }

        public Rational(int numerator)
        {
            this.numerator = numerator;
            denominator = 1;
        }

        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }

        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();
            return $"{numerator}/{denominator}";
        }

        private void Normalize()
        {
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
        }

        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void Reduce()
        {
            int gcd = GCD(this.numerator, this.denominator);
            this.numerator /= gcd;
            this.denominator /= gcd;
        }

        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator + b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator - b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.numerator,
                a.denominator * b.denominator
            );
        }

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.numerator == 0)
                throw new DivideByZeroException("Деление на ноль");
            return new Rational(
                a.numerator * b.denominator,
                a.denominator * b.numerator
            );
        }

        public static bool operator ==(Rational a, Rational b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rational other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}