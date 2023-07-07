using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            string path= Directory.GetCurrentDirectory().ToString();

            Console.WriteLine(path);
            MessageBox.Show(path);

            //cargar panatalla en picture box
            pictureBox1.Load(@"C:\Users\Salvador\Downloads\Juego-Vs-Ca-ones-master\idea.jpg");

            
        }

        private void finalizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("abrio");

        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizado Por \n\r" +
                            "Salvador Cirino Castrovinci \n\r" +
                            "Año 2023");
        }
    }
}
