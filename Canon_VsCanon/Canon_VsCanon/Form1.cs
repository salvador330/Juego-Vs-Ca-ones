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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abro archivo, lo ubico, agrego pantalla
            string path= Directory.GetCurrentDirectory().ToString();
            string pathPosicionado = path.Substring(0,path.Length-37);
            string pathMasImagen= pathPosicionado+@"idea.jpg";

            //Console.WriteLine(path);
            //MessageBox.Show(pathMasImagen);



            pictureBox1.Load(pathMasImagen);

            
        }

        private  void finalizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("abrio");
            Bitmap b;
            int y = 0;
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = (Image)b;
            Graphics g = Graphics.FromImage(b);

            //g.DrawLine(Pens.Black, new Point(0, 0), new Point(100, 100));
            int x = 0;
            for (int i = 0; i < 500; i++)
            {
                y = ((i * i) + i + 100);
                 g.DrawEllipse(Pens.DarkGreen, new Rectangle(x, y, 30, 30));

                x += 20;
            }
            

        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizado Por \n\r" +
                            "Salvador Cirino Castrovinci \n\r" +
                            "Año 2023");
        }
    }
}
