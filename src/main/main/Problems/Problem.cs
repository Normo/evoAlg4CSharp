using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace main
{
	public abstract class Problem
	{
		public int countGene;
		public int maxGenerations;
		public int countIndividuals;
		public int countChilds;
		public double recombinationProbability;
		public bool InvertOnMutate;
		public Helper.Enums.SelPropType SelPropType;
		public Helper.Enums.SelType SelType;
		public Helper.Enums.Encryption Encryption;
		public int TournamentMemberCount;
		public int minAllelValue;
		public int maxAllelValue;
		public bool? RecombBinaryIsSinglePoint;
		public bool RecombRealIsIntermidiate;
		public StringBuilder Output;
		
		public Problem ()
		{
			Output = new StringBuilder();
			RecombBinaryIsSinglePoint = true;
			RecombRealIsIntermidiate = true;
		}
		
		public abstract List<Genome> RecombineDefault (Genome genomeA, Genome genomeB);
		
		public List<Genome> RecombineBinary (Genome genomeA, Genome genomeB)
		{		
			
			List<double> childA = new List<double>();
			List<double> childB = new List<double>();
			
			if (!RecombBinaryIsSinglePoint.HasValue)
			{
				//todo gleichmäßige Rekomb.
				return null;
			}
			else if (RecombBinaryIsSinglePoint.Value)
			{
				// 1-Punkt Rekombination
				int rnd = Helper.GetRandomInteger(2, genomeA.Count - 2);
							
				childA.AddRange(genomeA.GetRange(0, rnd));
				childA.AddRange(genomeB.GetRange(rnd, genomeB.Count - rnd ));
				
				childB.AddRange(genomeB.GetRange(0, rnd));
				childB.AddRange(genomeA.GetRange(rnd, genomeA.Count - rnd ));
			}
			else
			{
				// 2-Punkt Rekombination
				int rnd1 = Helper.GetRandomInteger(1, genomeA.Count-2);
				int rnd2 = Helper.GetRandomInteger(1, genomeA.Count-rnd1-1);
				
				childA.AddRange(genomeA.GetRange(0, rnd1+1));
				childA.AddRange(genomeB.GetRange(rnd1+1, rnd2));
				if ((rnd1+rnd2+1) <= genomeA.Count -1)
					childA.AddRange(genomeA.GetRange((rnd1+rnd2+1), (genomeA.Count-1-rnd1-rnd2)));
				
				childB.AddRange(genomeB.GetRange(0, rnd1+1));
				childB.AddRange(genomeA.GetRange(rnd1+1, rnd2));
				if ((rnd1+rnd2+1) <= genomeA.Count -1)
					childB.AddRange(genomeB.GetRange((rnd1+rnd2+1), (genomeA.Count-1-rnd1-rnd2)));
			}
			List<Genome> result = new List<Genome>();
			result.Add(new GenomeReal(childA.ToArray()));
			result.Add(new GenomeReal(childB.ToArray()));
			return result;
		}
		
		public List<Genome> RecombineReal (Genome genomeA, Genome genomeB)
		{
			List<double> child = new List<double>();
			
			if (RecombRealIsIntermidiate)
			{
				// Intermediäre Rekombination
				
				for (int i = 0; i <= genomeA.Count-1; i++)
				{
					child.Add(((genomeA[i]+genomeB[i])/2));
				}
			}
			else
			{
				// Arithmetische Rekombination
				
				double a, b;
				double t = 0.33333;//Helper.GetRandomDouble();
				
				for (int i = 0; i <= genomeA.Count-1; i++)
				{
					if (genomeA[i] <= genomeB[i])
					{
						a = genomeA[i];
						b = genomeB[i];
					}
					else
					{
						a = genomeB[i];
						b = genomeA[i];
					}
					child.Add((a + t * (b - a)));
				}
			}
			
			List<Genome> result = new List<Genome>();
			result.Add(new GenomeReal(child.ToArray()));
			
			return result;	
		}
		
		public abstract void CalcFitnessDefault (Genome genome);
		public abstract void CalcFitnessBinary (Genome genome);
		public abstract void CalcFitnessReal (Genome genome);
		
		public abstract void MutateDefault (List<Genome> genomes);
		
		public void MutateBinary (List<Genome> genomes)
		{
			//Test double <-> binary
			
			//Ausgangswert
			double d = -512.123456789012345678901234567890;
			Console.WriteLine("Dec:\t\t" + d);
			Console.WriteLine("Int Bin:\t" + Convert.ToString((int)d,2));
			
			//double --> binary
			Console.Write("Dbl Bin:\t");
			BitArray bitarr = new BitArray(BitConverter.GetBytes(d));
			for (int i = 0; i <= bitarr.Length -1; i++)
			{
				Console.Write(bitarr[i] ? 1 : 0);
				//Punkte zur besseren Übersicht
//				if ((i+1) % 4 == 0)
//					Console.Write(".");
			}
			Console.WriteLine();
			
			//binary --> double
			byte[] byteArray = new byte[(int)Math.Ceiling((double)bitarr.Length / 8)];
			bitarr.CopyTo(byteArray, 0); 
			double result = BitConverter.ToDouble(byteArray, 0);
			Console.WriteLine("Dec:\t\t" + result);
		}
		
		public void MutateReal (List<Genome> genomes)
		{
			double rndProb = 0.3;
			
			Random random =  new Random(Guid.NewGuid().GetHashCode());
			 
			double rnd;
			
			foreach (Genome genome in genomes) {
				for (int i = 0; i <= genome.Count -1; i++) 
				{
					rnd = random.NextDouble();
					if (rnd <= rndProb)
						genome[i] += 0.1;
				}
			}
		}
	}
}

