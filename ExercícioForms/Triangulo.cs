using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioForms
{
    internal class Triangulo
    {
        private int lado1, lado2, lado3;

        public int Lado1 { get { return lado1; } set { lado1 = value; } }
        public int Lado2 { get { return lado2; } set { lado2 = value; } }
        public int Lado3 { get { return lado3; } set { lado3 = value; } }

        public Triangulo(int l1, int l2, int l3) {
            
            this.lado1 = l1;   
            this.lado2 = l2;   
            this.lado3 = l3;
        }

        public string RetornaTriangulo()
        {
            
            if (lado1 == lado2 && lado1 == lado3)
            {
                return "Triangulo Equilátero"; ;
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Triangulo Isósceles";

            } else
            {
                return "Triangulo Escaleno";
            }
            
        }
    }
}
