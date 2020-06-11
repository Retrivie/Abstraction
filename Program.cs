using System;

namespace Abstraction
{
    abstract class Shape
    {
        public abstract double area();
    }
    class Lingkaran : Shape
    {
        private double radius;
        public Lingkaran(double r)
        {
            radius = r;
        }
        public override double area()
        {
            return (3.14 * radius * radius);
        }
    }
    class Kotak : Shape
    {
        private double sisi;
        public Kotak(double s)
        {
            sisi = s;
        }
        public override double area()
        {
            return (sisi * sisi);
        }
    }
    class Segitiga : Shape
    {
        private double alas;
        private double tinggi;
        public Segitiga(double a, double t)
        {
            alas = a;
            tinggi = t;
        }
        public override double area()
        {
            return (0.5 * alas * tinggi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lingkaran L = new Lingkaran(5.0);
            Console.WriteLine("Luas Lingkaran \t= {0}", L.area());
            Kotak K = new Kotak(12.0);
            Console.WriteLine("Luas Persegi \t= {0}", K.area());
            Segitiga S = new Segitiga(12.0, 5.0);
            Console.WriteLine("Luas Segitiga \t= {0}", S.area());
        }
    }
}
