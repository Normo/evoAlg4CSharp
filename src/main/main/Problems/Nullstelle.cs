using System;

namespace main
{
	public class Nullstelle : Problem
	{
		public Nullstelle ()
		{
			minAllelValue = -50;
			maxAllelValue = 50;
		}

		#region implemented abstract members of main.Problem
		public override System.Collections.Generic.List<Genome> RecombineDefault (Genome genomeA, Genome genomeB)
		{
			throw new NotImplementedException ();
		}

		public override void CalcFitnessDefault (Genome genome)
		{
			//throw new NotImplementedException ();
			//Genome genome = new GenomeReal(new double[] {0.0,0.0,0.0,0.0,0.0});
			genome.Fitness = 0;
			
			double a = 0.0;
			
			foreach (double gene in genome)
			{
				a += gene * gene;
			}
			genome.Fitness = Math.Sqrt(a);
			//Console.WriteLine(genome.Fitness);
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

