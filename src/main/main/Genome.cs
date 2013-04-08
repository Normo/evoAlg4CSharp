using System;
using System.Collections.Generic;

namespace main
{
	public class Genome : List<int>
	{		
		
		
		private double _Fitness;

		public double Fitness {
			get {
				return _Fitness;
			}
			set { _Fitness = value; }
		}		
		
		public Genome () 
		{
			
		}
		
		public Genome(int size) 
		{
			//List<int> genome = new List<int>() {1};
			this.Add(1);
			
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			
			int rndInt;
			
			for(int i = 0; i < size-1; i++)
			{
				rndInt=rnd.Next(1, size+1);
				while (this.Contains(rndInt))
				{
					rndInt=rnd.Next(1,size+1);
				}
				this.Add(rndInt);
			}
			
			//Console.WriteLine("Create new Genome:");
			Console.WriteLine(string.Format("\tGenom: {0}", this.AsString()));
			FitnessFunctions.CalcTspFitness(this);
			//return genome;
		}
		
		/// <summary>
		/// Generiert ein zufälliges Genom
		/// </summary>
		/// <returns>Genom</returns>
		/// <param name='countGenes'>Anzahl der Gene</param>
//		public static List<int> GetNewGenome(int countGenes)
//		{	
//			List<int> genome = new List<int>() {1};
//			
//			Random rnd = new Random(Guid.NewGuid().GetHashCode());
//			
//			int rndInt;
//			
//			for(int i = 0; i < countGenes-1; i++)
//			{
//				rndInt=rnd.Next(1, countGenes+1);
//				while (genome.Contains(rndInt))
//				{
//					rndInt=rnd.Next(1,countGenes+1);
//				}
//				genome.Add(rndInt);
//			}
//			
//			//Console.WriteLine("Create new Genome:");
//			Console.WriteLine(string.Format("\tGenom: {0}", ListToString(genome)));
//			
//			return genome;
//		}
		
		/// <summary>
		/// Convertiert den Inhalt einer Liste in einen String.
		/// </summary>
		/// <returns>Inhalt als String</returns>
		/// <param name="list">Zu konvertierende Liste</param>
		private string AsString()
		{
			string tmp = "{";
			string sep = string.Empty;
			foreach (int i in this) {
				tmp = string.Format("{0}{1} {2}", tmp, sep, i);
				sep = ",";
			}
			tmp = string.Format("{0} }}", tmp);
			return tmp;
		}
	}
}

