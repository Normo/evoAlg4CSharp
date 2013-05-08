using System;

namespace main
{
	public class Nullstelle : Problem
	{
		public Nullstelle ()
		{
		}

		#region implemented abstract members of main.Problem
		public override System.Collections.Generic.List<Genome> RecombineDefault (Genome genomeA, Genome genomeB)
		{
			throw new NotImplementedException ();
		}

		public override void CalcFitnessDefault (Genome genome)
		{
			//throw new NotImplementedException ();
			
			genome.Fitness = 0;
			
			double i = 1.0;
			double fi = 0.0;
			double n = (double)genome.Count;
			double a = 0.0, b = 1.0;
			
			foreach (double gene in genome)
			{
				if (i + 1 == n)
				{
//					for (int j = 1; j <= n; j++)
				}
					
				i++;
			}
			
			
		}

		public override void CalcFitnessBinary (Genome genome)
		{
			throw new NotImplementedException ();
		}

		public override void CalcFitnessReal (Genome genome)
		{
			CalcFitnessDefault(genome);
		}

		public override void MutateDefault (System.Collections.Generic.List<Genome> genomes)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

