using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazProject
{
	internal class Pozicio
	{
		private int x;
		private int y;

		public Pozicio(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public int X { get => x; set => x = value; }
		public int Y { get => y; set => y = value; }

		public override string ToString()
		{
			return $"{this.x}, {this.y}";
		}
	
	
	
	
	
	}
}
