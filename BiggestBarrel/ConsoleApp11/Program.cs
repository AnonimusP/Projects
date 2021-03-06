﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    interface IWalec
    {
        void Pokaz();
    }
    class Kolo
    {
        public static double promien;
        public static double maxr;
        public Kolo(double r)
        {
            if (maxr < r)
            {
                maxr = r;
            }
            promien = r;
        }

        public virtual double Pole_powierzchni()
        {
            return promien * promien * 3.14;
        }
        public virtual double Dlugosc_obwodu()
        {
            return 2 * 3.14 * promien;
        }

    }
    class Walec : Kolo, IWalec
    {
        public double wysokosc;
        static public double maxh;

        public Walec(double wysokosc) : base(promien)
        {
            if (maxh < wysokosc)
            {
                maxh = wysokosc;
            }
            this.wysokosc = wysokosc;
        }
        public override double Pole_powierzchni()
        {
            return 2 * 3.14 * ((promien * promien) + (promien * wysokosc));
        }
        public double Objetosc()
        {
            return promien * promien * wysokosc * 3.14;
        }
        public string Najwiekszy()
        {
            return "Najwiekszy walec ma wymiary " + maxr + " x " + maxh + " Pole powierzchni: " + 2 * 3.14 * ((maxr * maxr) + (maxr * maxh)) + " a objetosc " + maxr * maxr * maxh * 3.14;
        }
        public void Pokaz()
        {
            Console.WriteLine("Parametry walca");
            Console.WriteLine("Promien: " + promien);
            Console.WriteLine("Wysokosc: " + wysokosc);
            Console.WriteLine("Pole powierzchni: " + Pole_powierzchni());
            Console.WriteLine("Objetosc: " + Objetosc());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double r, h;
            string max = "";
            Console.WriteLine("Podaj ilosc obiektow jaka chcesz wprowadzic");
            n = int.Parse(Console.ReadLine());
            Walec[] tab = new Walec[n];
            Kolo[] tab1 = new Kolo[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj promien kola jaki chcesz wprowadzic");
                r = double.Parse(Console.ReadLine());
                tab1[i] = new Kolo(r);
                r = 0;
                Console.WriteLine("Podaj wysokosc walca jaki chcesz wprowadzic");
                h = double.Parse(Console.ReadLine());
                tab[i] = new Walec(h);
                h = 0;
                tab[i].Pokaz();
                max = tab[i].Najwiekszy();
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
