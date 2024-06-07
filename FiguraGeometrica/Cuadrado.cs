using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cuadrado: Figura
    {
        public Cuadrado(float lado1)
        { // Se lee de la caja texto con el botón de GUARDAR
            Lado1 = lado1;
        }
        // Usará los métodos de la clase padre
        // sobreescribir el comportamiento de estos
        public override float area()
        {
            return  Lado1 * Lado1; // Area de un cuadrado será L*L
        }
        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1 + Lado1; ;
            //return 4 * Lado1; ;
        }
        public override float volumen()
        {
            throw new NotImplementedException(); //EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
