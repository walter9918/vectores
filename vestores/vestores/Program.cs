﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vestores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("control de versiones1");
            Console.WriteLine("control de versiones2");
            Console.WriteLine("control de versiones3");
            Console.WriteLine("control de versiones4");
            Console.WriteLine("control de versiones5");
            Console.WriteLine("probando control de versiones");
            Console.WriteLine("3 elevado a la 4 es igual a: {0}", potencia(3, 4));
            try
            {
                Console.WriteLine("5 elevado a la 5 es igual a: {0}", potencia(-5, 4));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message.ToString());

            }
            Console.WriteLine("2 elevado a la 5 es igual a:{0}", potencia(2, 5));
            vectorInicializar();
            Console.ReadKey();
        }
        public static double potencia(double x, double y)
        {
            if (x <= 0)
                throw new Exception("x debe ser positivo");
            if (y <= 0)
                throw new Exception("y debe der positivo");
            double po = 1;
            for (int i = 1; i <= y; i++)
            {
                po = po * x;
            }
            return po;
        }
        public static void vectorInicializar()
        {
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n***************\n");
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            for (int i = 0; i < 8; i++)
            {

                Console.WriteLine("Elemento indice {0} ---> {1}", (i + 1), x[i]);
            }
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];

            }
             Console.WriteLine("La sumatoria es {0}", suma);
             Console.WriteLine("El promedio es {0}", (double)suma / x.Length);
        }
    }
}