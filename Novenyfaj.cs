using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazProject
{
	internal class Novenyfaj
	{
		private string nev;
		private int vizigeny; //max 100%
		private int egeszsegAllapot; //0-10, ahol 0 ott halott noveny
		private int optimalisSuruseg;

		public Novenyfaj(string nev, int vizigeny, int egeszsegAllapot, int optimalisSuruseg)
		{
			
			this.Nev = nev;
			this.Vizigeny = vizigeny;
			this.EgeszsegAllapot = egeszsegAllapot;
			this.OptimalisSuruseg = optimalisSuruseg;
		}

		public string Azonosito { get => this.nev.Substring(0, 3); }
		public string Nev { get => nev; set => nev = value; }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegAllapot { get => egeszsegAllapot; set => egeszsegAllapot = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }


		public override string ToString()
		{
			return $"{this.nev} ({this.Azonosito}) {this.vizigeny} {this.egeszsegAllapot}";
		}
	
	
	
	}
}


	