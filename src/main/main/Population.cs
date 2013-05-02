using System;
using System.Collections.Generic;
using System.Linq;

namespace main
{
	/// <summary>
	/// Stellt eine Population dar.
	/// </summary>
	public class Population
	{	
		private Helper.Enums.Encryption _encryption;
		
		public List<Genome> curGeneration;
		public List<Genome> oldGeneration;
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='size'>Größe der Population</param>
		/// <param name='genomeSize'>Größe des einzelnen Genomes</param>
		public Population (int size, int genomeSize, double minAllelValue, double maxAllelValue, Helper.Enums.Encryption encryption)
		{
			_encryption = encryption;			
			curGeneration = new List<Genome>();
			oldGeneration = new List<Genome>();
			Genome tmp;
			
			for(int i = 0; i < size; i++)
			{
				if (_encryption == Helper.Enums.Encryption.None)
					throw new NotImplementedException(); //todo Genome mit Integerwerten
				else if (_encryption == Helper.Enums.Encryption.Binary)
				{
					throw new NotImplementedException(); //todo
				}
				else if (_encryption == Helper.Enums.Encryption.Real)
				{
					tmp = new GenomeReal(genomeSize, minAllelValue, maxAllelValue);
					// um Duplikate bei der Erzeugung der Population zu vermeiden
					while(curGeneration.Contains(tmp))
					{
						Console.WriteLine(String.Format("Duplikat: {0}\r\ni = {1}", tmp.AsString(),i));
						tmp = new GenomeReal(genomeSize, minAllelValue, maxAllelValue);
					}
					curGeneration.Add(tmp);
				}
			}
		}
		
		/// <summary>
		/// Setzt die aktuelle Generation als alte Generation
		/// </summary>
		public void SaveAsOldGen ()
		{
			oldGeneration.Clear();
			foreach (Genome genome in curGeneration) {
				oldGeneration.Add(genome.Copy());
			}
			curGeneration.Clear();
		}
		
		public bool ContainsGenome (Genome genome)
		{
			foreach (Genome popGenome in curGeneration)
			{
				if (popGenome.IsEqual(genome))
					return true;
			}
			foreach (Genome popGenome in oldGeneration)
			{
				if (popGenome.IsEqual(genome))
					return true;
			}
			return false;			
		}
		
		/// <summary>
		/// Konvertiert die aktuelle Generation in einen String.
		/// </summary>
		/// <returns>Inhalt als String</returns>
		public string CurrentGenerationAsString()
		{
			string tmp = string.Empty;
			foreach (Genome genome in curGeneration) 
			{
				tmp += "\t" + genome.AsString() + "\r\n";
			}
			return tmp;
		}
	}
}	

