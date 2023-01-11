using System;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiotec_exc.Repositories
{
	public class LerArquivo
	{
		public  void Lerarquivo()
		{
			string linha;

			try
			{
				StreamReader sr = new StreamReader("C://Externo_Mensagens v02");
				linha= sr.ReadLine();

				while(linha != null)
				{
					Console.WriteLine(linha);
					linha= sr.ReadLine();
				}

				sr.Close();
				Console.ReadLine();
			}
			
			catch (Exception e)
			{

				Console.WriteLine("Exeption" + e.Message);
			}

		
		}
	}
}