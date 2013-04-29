using System;
using System.Collections.Generic;

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
		
		public Problem ()
		{
			RecombBinaryIsSinglePoint = true;
			RecombRealIsIntermidiate = true;
		}
		
		public abstract List<Genome> RecombineDefault (Genome genomeA, Genome genomeB);
		
		public List<Genome> RecombineBinary (Genome genomeA, Genome genomeB)
		{		
			if (!RecombBinaryIsSinglePoint.HasValue)
			{
				//todo gleichmäßige Rekomb.
				return null;
			}
			else if (RecombBinaryIsSinglePoint.Value)
			{
				int rnd = Helper.GetRandomInteger(2, genomeA.Count - 2);
				
				List<int> childA = new List<int>();
				List<int> childB = new List<int>();
				
				childA.AddRange(genomeA.GetRange(0, rnd));
				childA.AddRange(genomeB.GetRange(rnd, genomeB.Count - rnd ));
				
				childB.AddRange(genomeB.GetRange(0, rnd));
				childB.AddRange(genomeA.GetRange(rnd, genomeA.Count - rnd ));
				           
				List<Genome> result = new List<Genome>();
				result.Add(new GenomeReal(childA.ToArray()));
				result.Add(new GenomeReal(childB.ToArray()));
				return result;
			}
			else
			{
				//todo 2-Punkt
				return null;
			}
		}
		
		public List<Genome> RecombineReal (Genome genomeA, Genome genomeB)
		{
			throw new NotImplementedException();
		}
		
		public abstract void CalcFitnessDefault (Genome genome);
		//public abstract void CalcFitnessBinary (Genome genome);
		//public abstract void CalcFitnessReal (Genome genome);
	}
}

