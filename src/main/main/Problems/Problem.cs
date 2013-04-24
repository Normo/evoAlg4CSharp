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
		
		public Problem ()
		{
		}
		
		public abstract List<Genome> RecombineDefault (Genome genomeA, Genome genomeB);
		//public abstract List<Genome> RecombineBinary (Genome genomeA, Genome genomeB);
		//public abstract List<Genome> RecombineReal (Genome genomeA, Genome genomeB);
		
		public abstract void CalcFitnessDefault (Genome genome);
		//public abstract void CalcFitnessBinary (Genome genome);
		//public abstract void CalcFitnessReal (Genome genome);
	}
}

