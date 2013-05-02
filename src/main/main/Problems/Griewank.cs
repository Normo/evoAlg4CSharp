using System;
using System.Collections.Generic;

namespace main
{
	public class Griewank : Problem
	{
		public Griewank ()
		{
			minAllelValue = -512;
			maxAllelValue = 511;
		}

		#region implemented abstract members of main.Problem
		public override List<Genome> RecombineDefault (Genome genomeA, Genome genomeB)
		{
			throw new NotImplementedException ();
			
		}

		public override void CalcFitnessDefault (Genome genome)
		{
			genome.Fitness = 0;
			
			//1 + sum[i = 1 bis n, xi² / 400n] - prod[i = 1 bis n, cos(xi / wurzel(i))] 
			// −512 ≤ xi ≤ 511, 1 ≤ i ≤ n (n = 5, 10, 15, 20, 25, 30, 40, . . .),
			
			double a = 0;
			double b = 1;
			double i = 1;
			
			foreach (int gene in genome)
			{
				// sum[i = 1 bis n, xi² / 400n]
				a = a + ((gene * gene) / (400 * genome.Count));
				// prod[i = 1 bis n, cos(xi / wurzel(i))]
				b = b + Math.Cos((double)gene / Math.Sqrt(i));
				i++;
			}
			genome.Fitness = 1 + a - b;
		}

		public override void CalcFitnessBinary (Genome genome)
		{
			throw new NotImplementedException ();
		}

		public override void CalcFitnessReal (Genome genome)
		{
			CalcFitnessDefault(genome);
		}
		#endregion

		#region implemented abstract members of main.Problem
		public override void MutateDefault (List<Genome> genomes)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

