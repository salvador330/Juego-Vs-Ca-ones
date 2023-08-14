using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canon_VsCanon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jugador JugadorA = new Jugador("JugadorA");
        Jugador JugadorB = new Jugador("JugadorB");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPantallauno();
            JugadorA.PosX = 100;
            JugadorA.PosY = 100;
            JugadorA.Angulo = 45;

            JugadorB.PosX = 100;
            JugadorB.PosY = 200;
            JugadorB.Angulo = 0;

        }

        private  void finalizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizado Por \n\r" +
                            "Salvador Cirino Castrovinci \n\r" +
                            "Año 2023");
        }

        private async void button3_JugA_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("abrio");
            //Bitmap b;
            //int y = 0;
            //b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.Image = (Image)b;
            //Graphics g = Graphics.FromImage(b);

            ////g.DrawLine(Pens.Black, new Point(0, 0), new Point(100, 100));
            //int x = 0;
            //for (int i = 0; i < 500; i++)
            //{
            //    y = ((i * i) + i + 100);
            //    g.DrawEllipse(Pens.DarkGreen, new Rectangle(x, y, 30, 30));

            //    x += 20;
            //}

            button3_JugA.Enabled = false;
            double y=290, x=0;
            while (x < 40)  //(x < 900 && y>=0 && y<300)
            {
                y = (30 * Math.Sin((JugadorA.Angulo * Math.PI) / 180)) * x - ((9.8*Math.Pow(x,2))/2);
                //MostrarBomba((int)x+90, (int)y);
                //debo incremetar x dependiendo del angulo
                //debo multiplicar a x*n veces para adaptarlo
                //idea de crear una clase que realiza porpocionalidad de x,y,t dependiendo del angulo
                //px.a=angulo  =>  x+Px.x   y+Px.x   t+Px.t

                MostrarBomba((int)x*10, 300+((int)(y/100)));
                 await Task.Delay(10);
                x=x+0.4;
               
            }
            button3_JugA.Enabled = true;



        }

        private void button4_JugB_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcion Para Mostrar la pantalla numero uno
        /// </summary>
        public void MostrarPantallauno()
        {
            //abro archivo, lo ubico, agrego pantalla
            string path = Directory.GetCurrentDirectory().ToString();
            string pathPosicionado = path.Substring(0, path.Length - 37);
            string pathMasImagen = pathPosicionado + @"pantallauno.png";



            pictureBox1.Load(pathMasImagen);
        }

        public void MostrarBomba(int x, int y)
        {
            //abro archivo, lo ubico, agrego pantalla
            string path = Directory.GetCurrentDirectory().ToString();
            string pathPosicionado = path.Substring(0, path.Length - 37);
            string pathMasImagen = pathPosicionado + @"bomba.png";



            //solucion a imagen se ve reborde gris
            pictureBox1.Controls.Add(pictureBox2_Bomba);
            pictureBox2_Bomba.Load(pathMasImagen);
            pictureBox2_Bomba.Location=new Point(x, y);
            pictureBox2_Bomba.BackColor = Color.Transparent;
        }

        private void button2_JugA_Click(object sender, EventArgs e)
        {
            JugadorA.Angulo = JugadorA.Angulo + 5;
           
           
        }

        private void button1_JugA_Click(object sender, EventArgs e)
        {
            JugadorA.Angulo= JugadorA.Angulo - 5;
           
        }
    }
}
