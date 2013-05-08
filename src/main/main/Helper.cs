using System;
using System.Collections.Generic;
using System.Collections;

namespace main
{
	public static class Helper
	{
		/// <summary>
		/// Konvertiert den Inhalt einer Liste in einem String.
		/// </summary>
		/// <returns>Inhalt als String</returns>
		/// <param name='list'>Zu konvertierende Liste</param>
		public static string ListToString (List<int> list)
		{
			string tmp = "{";
			string sep = string.Empty;
			foreach (int i in list) {
				tmp = string.Format("{0}{1} {2}", tmp, sep, i);
				sep = ",";
			}
			tmp = string.Format("{0} }}", tmp);
			return tmp;
		}
		
		/// <summary>
		/// Konvertiert den Inhalt einer Liste in einem String.
		/// </summary>
		/// <returns>Inhalt als String</returns>
		/// <param name='list'>Zu konvertierende Liste</param>
		public static string ListToString (List<double> list)
		{
			string tmp = "{";
			string sep = string.Empty;
			foreach (double i in list) {
				tmp = string.Format("{0}{1} {2}", tmp, sep, i);
				sep = ",";
			}
			tmp = string.Format("{0} }}", tmp);
			return tmp;
		}
		
		public static int GetRandomInteger()
		{
			Random rnd =  new Random(Guid.NewGuid().GetHashCode());
			return rnd.Next();
		}
		
		public static int GetRandomInteger(int min, int max)
		{
			Random rnd =  new Random(Guid.NewGuid().GetHashCode());
			return rnd.Next(min, max + 1);
		}
		
		public static double GetRandomDouble()
		{
			Random rnd =  new Random(Guid.NewGuid().GetHashCode());
			return rnd.NextDouble();
		}
		
		public static BitArray DoubleToBitArray(double value)
		{
			return new BitArray(BitConverter.GetBytes(value));
		}
		
		public static double BitArrayToDouble(BitArray value)
		{
			byte[] byteArray = new byte[(int)Math.Ceiling((double)value.Length / 8)];
			value.CopyTo(byteArray, 0); 
			return BitConverter.ToDouble(byteArray, 0);
		}
		
		public static class Enums
		{
			public enum Encryption { None, Binary, Real };
			public enum SelPropType { Fitness, Ranking };
			public enum SelType { Roulette, SingleTournament, MultiTournament }; 
		}
		
		public static class Fitness
		{
			/// <summary>
			/// Ermittelt das Genom mit dem besten Fitnesswert
			/// </summary>
			/// <returns>Genom</returns>
			public static Genome GetBestGenome(List<Genome> generation)
			{
				generation.Sort((a,b) => a.Fitness.CompareTo(b.Fitness));
				return generation[0];
			}
			
			/// <summary>
			/// Berechnet Summe aller Fitnesswerte der aktuellen Generation
			/// </summary>
			/// <returns>Summe Gesamtfitness</returns>
			public static double GetTotalFitness(List<Genome> generation)
			{
				double totalFitness = 0;
				foreach (Genome genome in generation)
				{
					totalFitness += genome.Fitness;
				}
				return totalFitness;
			}
			
			/// <summary>
			/// Berechnet die durchschnittliche Fitness der aktuellen Population
			/// </summary>
			/// <returns>Fitnesswert</returns>
			public static double GetAverageFitness(List<Genome> generation)
			{
				return GetTotalFitness(generation) / generation.Count;
			}
			
		}
		
		public static class Selection 
		{
			public static void CalcSelPropByFitness(List<Genome> generation)
			{
				double totalFitness = Helper.Fitness.GetTotalFitness(generation);
				foreach (Genome genome in generation)
				{
					genome.SelectionProbability = genome.Fitness / totalFitness;
				}
			}
			
			public static void CalcSelPropByRanking(List<Genome> generation)
			{
				generation.Sort((a,b) => a.Fitness.CompareTo(b.Fitness));
				foreach (Genome genome in generation)
				{
					// 2 / r * ( 1 - (i-1) / (r-1))
					genome.SelectionProbability = (double)(2 / (double)generation.Count) * ( 1 - ((double)(generation.IndexOf(genome))/(double)(generation.Count-1)));
				}
			}
		}
	}
}

