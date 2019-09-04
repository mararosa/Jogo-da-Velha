using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula12Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Triangulo t = new Triangulo();
            t.Altura = 5;
            t.Base = 5;
            int area = t.Area();

            Triangulo t2 = new Triangulo();
            t2.Base = 10;
            t2.Altura = 10;
            int areaT2 = t2.Area();


        }

    }

    public class Triangulo
    {
      public int Base;
      public int Altura;

    public int Area()
    {
        return Base * Altura / 2;
    }

    }

    ///// Crie uma classe Calculadora, com os métodos Somar, Subtrair, Multiplicar e Dividir. Utilize os métodos.
    ///

    public class Calculadora
    {
        public int a, b;

        public int Somar()
        {
            return a + b;
        }

        public int Subtrair;
        public int Multiplicar;
        public int Dividir;
    }

}
