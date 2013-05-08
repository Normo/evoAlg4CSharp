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
			int capacity = genomeA.Capacity;
			List<double> childA = new List<double>(capacity);
			List<double> childB = new List<double>(capacity);
			
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
			List<Genome> result = new List<Genome>(2);
			result.Add(new GenomeReal(childA.ToArray()));
			result.Add(new GenomeReal(childB.ToArray()));
			return result;
		}
		
		public List<Genome> RecombineReal (Genome genomeA, Genome genomeB)
		{
			List<double> child = new List<double>(genomeA.Capacity);
			
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
			
			List<Genome> result = new List<Genome>(1);
			result.Add(new GenomeReal(child.ToArray()));
			
			return result;	
		}
		
		public abstract void CalcFitnessDefault (Genome genome);
		public abstract void CalcFitnessBinary (Genome genome);
		public abstract void CalcFitnessReal (Genome genome);
		
		public abstract void MutateDefault (List<Genome> genomes);
		
		public void MutateBinary (List<Genome> genomes)
		{
			//throw new NotImplementedException ();
			
			// Erzeugung zweier Zufallsindices
//			Random rnd = new Random(Guid.NewGuid().GetHashCode());
//			// 1 < z1 < Populationsgröße
//			int z1 = rnd.Next(1, countIndividuals);
//			// 0 < z2 < Anzahl der Gene
//			int z2 = rnd.Next(1, genomes[0].Count);
//			
//			double rndProb = 1.0 / countIndividuals;
			
			BitArray bitarray = new BitArray(Helper.DoubleToBitArray(512.0));
			foreach (Genome genome in genomes)
			{
				Console.Write("\r\nGenom: ");
				for (int i = 0; i <= genome.Count -1; i++)
				{
					bitarray = Helper.DoubleToBitArray(genome[i]);
					Console.Write(String.Format("\r\n\tDec:\t\t {0}\r\n\tVorher:\t", genome[i].ToString()));
					// Ausgabe und anschließend Invertierung
					for (int j = 0; j <= bitarray.Count -1; j++)
					{
						Console.Write(bitarray[j] ? 1 : 0);
						//Punkte zur besseren Übersicht
						if ((j+1) % 4 == 0)
						Console.Write(".");
						bitarray[j] = bitarray[j] ? false : true;
					}
					Console.Write("\r\n\tNachher:\t");
					// Ausgabe nach Invertierung
					for (int k = 0; k <= bitarray.Length -1; k++)
					{
						Console.Write(bitarray[k] ? 1 : 0);
						//Punkte zur besseren Übersicht
				        if ((k+1) % 4 == 0)
				          Console.Write(".");
					}
					byte[] byteArray = new byte[(int)Math.Ceiling((double)bitarray.Length / 8.0)];
					bitarray.CopyTo(byteArray, 0); 
					double result = BitConverter.ToDouble(byteArray, 0);
					Console.WriteLine("\r\n\tDec:\t\t" + result); 
				}
			} 
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
					{
						genome[i] += (Convert.ToBoolean(random.Next(2)))? 0.05 : -0.05;
					}
				}
			}
		}
	}
}

