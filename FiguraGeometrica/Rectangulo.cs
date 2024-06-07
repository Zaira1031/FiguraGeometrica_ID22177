using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Rectangulo: Figura // clase hija de figura
    {
        //ESTA CLASE REQUIERE DOS LADOS PARA FUNCIONAR
       
        //CREAMOS NUEVO LADO2
        private float lado2;
        // constructor para rectangulo 
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
        // Usamos su constructor (el de la clse padre)
        public Rectangulo(float lado1, float lado2)
        { // Se lee de la caja texto con el botón de GUARDAR
           this.Lado1 = lado1;// hace unicamente el valor de cantidad del lado sea disponible
            // para la clase rectangulo, cuando no se use rectangulo lla variable será =0
            this.Lado2 = lado2;
        }
        // Usará los métodos de la clase padre
        // sobreescribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado2; 
        }
        public override float perimetro()
        {
            return  (2 * Lado1) + (2* Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException(); //EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
