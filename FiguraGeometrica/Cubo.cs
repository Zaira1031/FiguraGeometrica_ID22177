using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cubo: Figura
    {
        public Cubo(float lado1)
        { // Se lee de la caja texto con el botón de GUARDAR
            Lado1 = lado1;
        }
        // Usará los métodos de la clase padre
        // sobreescribir el comportamiento de estos
        public override float area()
        {
            // Área superficial de un cubo = 6 * lado^2
            return 6 * (float)Math.Pow(Lado1, 2);
        }
        public override float perimetro()
        {

            return 12* Lado1;
        }
        public override float volumen()
        {
            // Implementación del método volumen() que calcula el volumen del cubo
            return (float)Math.Pow(Lado1, 3);
        }
    }
}
