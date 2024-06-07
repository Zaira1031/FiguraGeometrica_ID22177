using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Prisma: Figura
    {
        private float lado2;
        private float lado3;
        public float Lado2
        {
            set
            {
                //pregunta si el lado es <0
                if (value < 0)
                {
                    lado2 = 0; // no puede haber lados negativos 
                    //por lo que lo mandará como 0
                }
                else
                {
                    lado2 = value; // value es el valor del textbox
                }
            }
            get// obtener el valor 
            {
                return lado2; // regresa el valor de la variable lado1
            }
        }
        public float Lado3//AREA TOTAL
        {
            set
            {
                //pregunta si el lado es <0
                if (value < 0)
                {
                    lado3 = 0; // no puede haber lados negativos 
                    //por lo que lo mandará como 0
                }
                else
                {
                    lado3 = value; // value es el valor del textbox
                }
            }
            get// obtener el valor 
            {
                return lado3; // regresa el valor de la variable lado1
            }
        }
        public Prisma(float lado1, float lado2, float lado3)
        { // Se lee de la caja texto con el botón de GUARDAR
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
        // Usará los métodos de la clase padre
        // sobreescribir el comportamiento de estos
        public override float area()
        {
            return (2* Lado1* Lado2) + (2* Lado1* Lado3) + (2* Lado2* Lado3);
        }
        public override float perimetro()
        {
            return (4 * Lado1) + (4 * Lado2) + (4 * Lado3);
        }
        public override float volumen()
        {
            return Lado1* Lado2* Lado3;
        }
    }
}
