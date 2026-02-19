using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazProject
{
	internal class Cella
	{
		private Pozicio poz;
		private Novenyfaj noveny;
		private int egyedszam;
		List<Riasztas> riasztasok;
		List<Szenzor> szenzorok;
		private Pozicio pozicio;

		public Cella(Pozicio pozicio)
		{
			this.pozicio = pozicio;
		}

		public Cella(Pozicio poz, Novenyfaj noveny, int egyedszam, List<Riasztas> riasztasok, List<Szenzor> szenzorok)
		{
			this.Poz = poz;
			this.Noveny = noveny;
			egyedszam = 0;
			this.Riasztasok = riasztasok;
			this.Szenzorok = szenzorok;
		}

		public bool UresCella
		{
			get
			{
				return this.Noveny == null;
			}
		}

		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal Pozicio Poz { get => poz; set => poz = value; }
		internal Novenyfaj Noveny { get => noveny; set => noveny = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }

		public bool Beultet(Novenyfaj noveny, int egyedSzam)
		{
			if (this.UresCella)
			{
				this.noveny = noveny;
				this.egyedszam = egyedszam;
				return true;

			}
			else if (noveny == this.noveny)
			{

				this.egyedszam += egyedSzam;
				return true;

			}

			else
			{
				return false;
			}


		}
	}
}
