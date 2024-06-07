using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Triangulo : Figura
    {
        // Creamos buevo LADO3
        private float altura;
        public float Altura
        {
            set
            {
                //pregunta si el lado es <0
                if (value < 0)
                {
                    altura = 0; // no puede haber lados negativos 
                    //por lo que lo mandará como 0
                }
                else
                {
                    altura = value; // value es el valor del textbox
                }
            }
            get// obtener el valor 
            {
                return altura; // regresa el valor de la variable lado1
            }
        }

        //CREAMOS NUEVO LADO2
        private float bas;
        // constructor para rectangulo 
        public float Bas
        {
            set
            {
                //pregunta si el lado es <0
                if (value < 0)
                {
                    bas = 0; // no puede haber lados negativos 
                    //por lo que lo mandará como 0
                }
                else
                {
                    bas = value; // value es el valor del textbox
                }
            }
            get// obtener el valor 
            {
                return bas; // regresa el valor de la variable lado1
            }
        }
        // Usamos su constructor (el de la clse padre)
        public Triangulo(float lado1, float bas, float altura)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea disponible
            //para la clase rectangulo, cuando no se use rectangulo la variable sera =0
            this.Bas = bas;
            this.Altura = altura;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return (Bas * Altura) /2 ;
        }

        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1;
        }

        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
