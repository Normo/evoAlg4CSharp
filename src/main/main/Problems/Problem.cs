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
		public List<bool> templateGenom;
		
		public Problem ()
		{
			Output = new StringBuilder();
			RecombBinaryIsSinglePoint = true;
			RecombRealIsIntermidiate = true;
		}
		
		public abstract List<Genome> RecombineDefault (Genome genomeA, Genome genomeB);
		
		public List<Genome> RecombineBinary (Genome genomeA, Genome genomeB)
		{		
			//Console.WriteLine(String.Format("\r\nRecombineBinary:\r\n\tGenom A:\t{0}\r\n\tGenom B:\t{1}", genomeA.AsString(),genomeB.AsString()));
			
			List<double> childA = new List<double>(countGene);
			List<double> childB = new List<double>(countGene);
			
			
			
			if (!RecombBinaryIsSinglePoint.HasValue)
			{
				// Gleichmäßige Rekombination
				
				// Erzeuge Template einmalig
				if (templateGenom == null)
				{
					templateGenom = new List<bool>();
					Random random = new Random(Guid.NewGuid().GetHashCode());
					for (int i=0; i < countGene; i++)
					{
						templateGenom.Add(Convert.ToBoolean(random.Next(2)));
					}
				}
				
				childA.AddRange(genomeA);
				childB.AddRange(genomeB);
				
				// Tausche Allele anhand Template
				double tmp;
				for (int i=0; i < countGene; i++)
				{
					// Wenn false im Template -> tausche Allele
					if (!templateGenom[i])
					{
						tmp = childA[i];
						childA[i] = childB[i];
						childB[i] = tmp;
					}
				}
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
		
		public abstract void MutateDefault (List<Genome> genomes);
		
		public void MutateBinary (List<Genome> genomes)
		{
			//throw new NotImplementedException ();
			
			// Erzeugung zweier Zufallsindices
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			// 0 < z2 < Anzahl der Gene
			int z = rnd.Next(0, genomes[0].Count);
			
			BitArray bitarray = Helper.DoubleToBitArray(genomes[0][z]);

			for (int j = 0; j <= bitarray.Count -1; j++)
			{
				bitarray[j] = bitarray[j] ? false : true;
			}
			
			genomes[0][z]= Helper.BitArrayToDouble(bitarray);
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
						//genome[i] += (Convert.ToBoolean(random.Next(2)))? 0.05 : -0.05;
						genome[i] += genome[i] < 0 ? 0.05 : -0.05;
					}
				}
			}
		}
	}
}

