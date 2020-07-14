using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporalneOperacije
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime tackaUvremenu = DateTime.Now;
			Console.WriteLine("Sada je: " + tackaUvremenu.ToString("ddd mmmm HH:MM"));

			TimeSpan periodVremena = new TimeSpan(7, 12, 0, 0);
			DateTime buducnost = tackaUvremenu + periodVremena;
			Console.WriteLine("Neka buducnost:) : " + buducnost);
			Console.WriteLine("Buducnost minus sada: " + (buducnost - tackaUvremenu));
			Console.ReadKey();
		}
	}
}
