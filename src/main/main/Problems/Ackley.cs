using System;
using System.Collections.Generic;

namespace main
{
	public class Ackley : Problem
	{
		public Ackley ()
		{
			minAllelValue = -20;
			maxAllelValue = 30;
		}

		#region implemented abstract members of main.Problem
		public override List<Genome> RecombineDefault (Genome genomeA, Genome genomeB)
		{
			throw new NotImplementedException ();
		}

		public override void CalcFitnessDefault (Genome genome)
		{
			//Genome genome = new GenomeReal(new double[] {0.0,0.0,0.0,0.0,0.0});
			genome.Fitness = 0;
			
			// Summenformeln
			double a = 0.0, b = 0.0;
			// Exponenten
			double c = 0.0, d = 0.0;
			double i = 0.0;
			
			foreach (double gene in genome)
			{
				// sum(xi²)
				a = a + (gene * gene);
				// sum[cos(2PI*xi²)]
				b = b + Math.Cos(2*Math.PI*gene);
				i++;
			}
			
			c = 0.2 * Math.Sqrt(1/i * a);
			d = (1/i) * b;
			genome.Fitness = 20.0 + Math.Exp(1) - 20.0 * Math.Exp (c) - Math.Exp(d);
			genome.Fitness *= genome.Fitness < 0 ? -1 : 1;
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

		public override void MutateDefault (List<Genome> genomes)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

