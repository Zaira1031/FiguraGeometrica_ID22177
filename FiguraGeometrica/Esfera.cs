using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Esfera: Figura
    {
        // Usamos su constructor(el de la clse padre)
        //usamos el constructor de la clase padre
        public Esfera(float radio)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return 4 * 3.1416F * (float)Math.Pow(Lado1, 2);
            //AGREGAMOS F AL FINAL DE UN NUMERO CUANDO
            //ES UNA CONSTANTE NO DEFINIDA EN UNA VARIABLE
            //PREVIAMENTE, ASI EL PROGRAMA SABE QUE ES UN #
        }

        public override float perimetro()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }

        public override float volumen()
        {
            return ((4 * (3.1416F * (float)Math.Pow(Lado1, 3))))/3;
        }
    }
}
