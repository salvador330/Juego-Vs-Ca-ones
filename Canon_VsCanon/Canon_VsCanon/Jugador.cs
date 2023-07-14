using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canon_VsCanon
{
    public class Jugador
    {
		private string _nombre;
		private int posX;
		private int posY;
		private int angulo;
		private int _vida;

		public int Vida
		{
			get { return _vida; }
			set { _vida = value; }
		}


		public Jugador(string nombre)
		{
			this.Nombre=nombre;
		}


		public int Angulo
		{
			get { return angulo; }
			set { angulo = value; }
		}



		public int PosY
		{
			get { return posY; }
			set { posY = value; }
		}


		public int PosX
		{
			get { return posX; }
			set { posX = value; }
		}


		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

	}
}
