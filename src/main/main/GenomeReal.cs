using System;
using System.Collections.Generic;

namespace main
{
	public class GenomeReal : Genome
	{				
			
		public GenomeReal()
		{
			
		}
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='size'>Anzahl der Gene</param>
		public GenomeReal(int size, int minValue, int maxValue) 
		{
			//List<int> genome = new List<int>() {1};
			//this.Add(1);
			
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			
			int rndInt;
			
			//for(int i = 0; i < size-1; i++)
			for(int i = 0; i < size; i++)
			{
				rndInt=rnd.Next(minValue, maxValue);
				while (this.Contains(rndInt))
				{
					rndInt=rnd.Next(minValue,maxValue);
				}
				this.Add(rndInt);
			}
			
			//Console.WriteLine("Create new Genome:");
//			Console.WriteLine(string.Format("\tGenom: {0}", this.AsString()));
			//return genome;
		}
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='arr'>Integer Array, mit dem Genom initialisiert wird</param>
		public GenomeReal (int[] arr)
		{
			this.Clear();
			this.AddRange(arr);
		}
		
		/// <summary>
		/// Kopiert ein Genom
		/// </summary>
		public override Genome Copy()
		{
			Genome result = new GenomeReal (this.ToArray());
			result.Fitness = this.Fitness;
			return result;
		}
	}
}

