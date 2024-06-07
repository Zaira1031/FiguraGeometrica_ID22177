using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:/Users/carlo/source/repos/Zaira1031/FiguraGeometrica/imagenes/cubo.png";
            imagen.BackgroundImage = Image.FromFile(rutaImagen);
            label2.Visible = true;
            tLado1.Visible = true;
            label5.Visible = false;
            tLado2.Visible = false;
            label8.Visible = false;
            tLado3.Visible = false;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
            label7.Visible = false;
            tRadio.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            tLado1.Visible = true;
            label5.Visible = false;
            tLado2.Visible = false;
            label8.Visible = false;
            tLado3.Visible = false;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
            label7.Visible = false;
            tRadio.Visible = false;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            tLado1.Clear();
            tLado2.Clear();
            tLado3.Clear();
            tAltura.Clear();
            tBase.Clear();
            tApo.Clear();
            tRadio.Clear();
            informacion.Clear();

        }

        private void salir_Click(object sender, EventArgs e)
        {
            // La función Application.Exit() cierra la aplicación actual.
            Application.Exit();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Guardado con ÉXITO", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void triangulo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            tLado1.Visible = true;
            label3.Visible = true;
            tBase.Visible = true;
            label4.Visible = true;
            tAltura.Visible = true;
            label5.Visible = false;
            tLado2.Visible = false;
            label8.Visible = false;
            tLado3.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
            label7.Visible = false;
            tRadio.Visible = false;
        }

        private void rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            
            label2.Visible = true;
            tLado1.Visible = true;
            label5.Visible = true;
            tLado2.Visible = true;
            label8.Visible = false;
            tLado3.Visible = false;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
            label7.Visible = false;
            tRadio.Visible = false;
        }

        private void pliregu_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            tLado1.Visible = true;
            label6.Visible = true;
            tApo.Visible = true;
            label5.Visible = true;
            tLado2.Visible = true;
            label8.Visible = false;
            tLado3.Visible = false;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label7.Visible = false;
            tRadio.Visible = false;
        }

        private void circulo_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            tRadio.Visible = true;
            label2.Visible = false;
            tLado1.Visible = false;
            label5.Visible = false;
            tLado2.Visible = false;
            label8.Visible = false;
            tLado3.Visible = false;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
        }

        private void prisma_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            tLado1.Visible = true;
            label5.Visible = true;
            tLado2.Visible = true;
            label8.Visible = true;
            tLado3.Visible = true;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
            label7.Visible = false;
            tRadio.Visible = false;

        }

        private void esfera_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:/Users/carlo/source/repos/Zaira1031/FiguraGeometrica/imagenes/esfera.png";
            imagen.BackgroundImage = Image.FromFile(rutaImagen);
            label7.Visible = true;
            tRadio.Visible = true;
            label2.Visible = false;
            tLado1.Visible = false;
            label5.Visible = false;
            tLado2.Visible = false;
            label8.Visible = false;
            tLado3.Visible = false;
            label3.Visible = false;
            tBase.Visible = false;
            label4.Visible = false;
            tAltura.Visible = false;
            label6.Visible = false;
            tApo.Visible = false;
        }

        private void imagen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                if (float.TryParse(tLado1.Text, out float Lado1))
                {
                    Cuadrado cuadrado = new Cuadrado(Lado1);
                    informacion.Text = "CUADRADO" + "\nAREA: " + cuadrado.area().ToString() + "\nPERIMETRO: " + cuadrado.perimetro().ToString();

                }
                
            }
            if (triangulo.Checked)
            {
                if (float.TryParse(tLado1.Text, out float Lado1)&& 
                    float.TryParse(tBase.Text, out float Bas)&& 
                    float.TryParse(tAltura.Text, out float Altura))
                {
                    Triangulo triangulo = new Triangulo(Lado1, Bas, Altura);
                    informacion.Text = "TRIANGULO" + "\nAREA: " + triangulo.area().ToString() + "\nPERIMETRO: " + triangulo.perimetro().ToString();

                }
            }
            if (rectangulo.Checked)
            {
                if (float.TryParse(tLado1.Text, out float Lado1)&& float.TryParse(tLado2.Text, out float Lado2))
                {
                    Rectangulo rectangulo = new Rectangulo(Lado1, Lado2);
                    informacion.Text = "RECTANGULO" + "\nAREA: " + rectangulo.area().ToString() + "\nPERIMETRO: " + rectangulo.perimetro().ToString();

                }

            }
            if (circulo.Checked)
            {
                if (float.TryParse(tRadio.Text, out float Radio) )
                {
                    Circulo circulo = new Circulo(Radio);
                    informacion.Text = "CIRCULO" + "\nAREA: " + circulo.area().ToString() + "\nPERIMETRO: " + circulo.perimetro().ToString();

                }

            }
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked && tLado1.Text != "" && informacion.Text != "")
            {
                string rutaImagen = "C:/Users/carlo/source/repos/Zaira1031/FiguraGeometrica/imagenes/cuadrado.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if(triangulo.Checked && tLado1.Text != "" && tBase.Text != "" && tAltura.Text != ""
                && informacion.Text != "")
            {
                string rutaImagen = "C:/Users/carlo/source/repos/Zaira1031/FiguraGeometrica/imagenes/triangulo.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (rectangulo.Checked && tLado1.Text != "" && tLado2.Text != "" && informacion.Text != "")
            {
                string rutaImagen = "C:/Users/carlo/source/repos/Zaira1031/FiguraGeometrica/imagenes/rectangulo.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (circulo.Checked && tRadio.Text != "" && informacion.Text != "")
            {
                string rutaImagen = "C:/Users/carlo/source/repos/Zaira1031/FiguraGeometrica/imagenes/circulo.jpg";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
        }

        private void tRadio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
