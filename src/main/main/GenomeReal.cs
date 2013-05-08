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
		public GenomeReal(int size, double minValue, double maxValue) 
		{
			//List<int> genome = new List<int>() {1};
//			this.Add(1); //todo 1.1 Travelings Salesman ... muss dafür immer umkommentiert werden
			
			// Lege Kapazität des Genoms vorab fest
			this.Capacity = size;
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			
			double rndInt;
			
//			for(int i = 0; i < size-1; i++)
			for(int i = 0; i < size; i++) //todo 1.2
			{
				rndInt=rnd.NextDouble() * (maxValue - minValue) + minValue;
				while (this.Contains(rndInt))
				{
					rndInt=rnd.NextDouble() * (maxValue - minValue) + minValue;
				}
				this.Add(rndInt);
			}
		}
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='arr'>Integer Array, mit dem Genom initialisiert wird</param>
		public GenomeReal (double[] arr)
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

