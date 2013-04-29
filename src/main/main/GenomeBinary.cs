using System;
using System.Collections.Generic;

namespace main
{
	public class GenomeBinary : Genome
	{				
			
		public GenomeBinary()
		{
			
		}
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='size'>Anzahl der Gene</param>
		public GenomeBinary(int size) 
		{
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			int rndInt = 0;
			
			for (int i = 0; i < size; i++) {
				rndInt = rnd.Next(0, 2);
				this.Add(rndInt);
			}
		}
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='arr'>Integer Array, mit dem Genom initialisiert wird</param>
		public GenomeBinary (double[] arr)
		{
			this.Clear();
			this.AddRange(arr);
		}
		
		/// <summary>
		/// Kopiert ein Genom
		/// </summary>
		public override Genome Copy()
		{
			Genome result = new GenomeBinary (this.ToArray());
			result.Fitness = this.Fitness;
			return result;
		}
	}
}

