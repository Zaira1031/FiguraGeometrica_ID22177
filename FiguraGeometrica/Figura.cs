using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    abstract class Figura // ES LA CLASE PADRE
    {
        // PERMITE EL INGRESO DE UN LADO, PARA CREAR
        // UNA NUEVA FIGURA GEOMETRICA 
        // UNA FIGURA PARA EXISTIR NECESITA MÍNIMO UN LADO
        //CLASE MOLDE
        // Declarar variables para las clases hijas que se guardaran en un caja
        // de memoria, el valor del primer lado

        //VARIABLE SERÁ PRIVADA: ES PARA UTILIZARLA UNICAMETE EN DONDE ES NECESARIA 
        private float lado1;//PERMITE DECIMALES
        //ATRIBUTOS/ PROPIEDADES
        //CONSTRUCTOR 
        // TIENE COMO DEFINICIÓN 
        public float Lado1
        {
            // modificador para el valor (#) en la caja de memoria

            set// obtener VALOR
            {
                //pregunta si el lado es <0
                if (value<0)
                {
                    lado1 = 0; // no puede haber lados negativos 
                    //por lo que lo mandará como 0
                }
                else
                {
                    lado1 = value; // value es el valor del textbox
                }
            }

            get// obtener el valor 
            {
                return lado1; // regresa el valor de la variable lado1
            }


        }
        // DEFINIR LOS METODOS, FUNCIONES, OPERACIONES DE LA CLASE PADRE QUE LA TENDRÁN LAS CLASES HIJAS
        // METODOS DE TIPO PUBLICO PARA QUE TODOS LO USEN
        // METODOS ABSTRACTOS VAN VACIOS, YA QUE CADA HIJA DEFINIRÁ SUS OPERACIONES 
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();

    }


}
