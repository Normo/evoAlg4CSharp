using System;
using System.Collections.Generic;
using System.Linq;

namespace main
{
	public static class Selection
	{		
		public static void Plus (Population population, int TopCount)
		{
			List<Genome> newGen = new List<Genome> (population.totalSize*2);
			newGen.AddRange (population.curGeneration);
			newGen.AddRange (population.oldGeneration);
			newGen.Sort((a,b) => a.Fitness.CompareTo(b.Fitness));
			newGen.RemoveRange(TopCount, newGen.Count() - TopCount);

			population.curGeneration.Clear();
			population.curGeneration.AddRange(newGen);
		}
		
		public static void Comma (Population population, int TopCount)
		{
			List<Genome> newGen = new List<Genome> (population.totalSize);
			newGen.AddRange (population.curGeneration);
			newGen.Sort((a,b) => a.Fitness.CompareTo(b.Fitness));

			newGen.RemoveRange(TopCount, newGen.Count() - TopCount);

			population.curGeneration.Clear();
			population.curGeneration.AddRange(newGen);
		}
		
		public static void RandomParents (List<Genome> parents, ref int indexA, ref int indexB)
		{
			indexA = Helper.GetRandomInteger(1, parents.Count)-1;
			indexB = Helper.GetRandomInteger(1, parents.Count)-1;
		}
		
		public static Genome Roulette (List<Genome> generation)
		{			
			double rnd = Helper.GetRandomDouble();
			double cur = 0;
			
			for (int i = 0; i < generation.Count; i++) {
				cur += generation[i].SelectionProbability;
				if ( rnd <= cur)
					return generation[i];
			}
			return null;
		}
		
		public static Genome SingleTournament(List<Genome> generation, int memberCount)
		{
			List<Genome> member = new List<Genome>();
			for (int i = 0; i < memberCount; i++) {
				member.Add(generation[Helper.GetRandomInteger(0,generation.Count-1)]);
			}
			
			member.Sort((a,b) => a.Fitness.CompareTo(b.Fitness));
			
			return member[0].Copy();
		}
		
		public static Genome MultiTournament(List<Genome> generation, int memberCount)
		{			
			Dictionary<Genome, int> tournament = new Dictionary<Genome, int>();
			int winCounter;
			
			Random random =  new Random(Guid.NewGuid().GetHashCode());
			
			foreach (Genome genome in generation)
			{
				winCounter = 0;
				
				for (int i = 0; i < memberCount; i++) {
					if (genome.SelectionProbability > generation[random.Next(0, generation.Count)].SelectionProbability)
						winCounter++;
				}				
				tournament.Add(genome, winCounter);
				
			}
			List<KeyValuePair<Genome, int>> winTable = tournament.ToList();
			
			winTable.Sort((a,b) => b.Value.CompareTo(a.Value));
			return winTable[0].Key;
		}
	}
}

