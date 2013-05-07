using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gtk;
using System.Text;
using System.ComponentModel;

namespace main
{
	public class Evolution
	{
		public delegate List<Genome> RecombineMethod (Genome genomeA, Genome genomeB);
		public delegate void FitnessMethod (Genome genome);
		public delegate void MutateMethod (List<Genome> genomes);
		
		public RecombineMethod Recombine;
		public FitnessMethod CalcFitness;
		public MutateMethod Mutate;
		
		public int countGene;							// Anzahl der Gene
		public int maxGenerations;						// Maximale Anzahl zu erzeugender Generationen
		public int countIndividuals;					// Anzahl an Individuen einer Population
		public int countChilds;							// Anzahl zu erzeugender Kinder
		public double recombinationProbability;			// Rekombinationswahrscheinlichkeit
		public bool InvertOnMutate;						// Mutation: true = invertieren, false = tauschen
		public double minAllelValue;						// Minimaler Wert der Allele
		public double maxAllelValue;						// Maximaler Wert der Allele
		public Helper.Enums.SelPropType SelPropType;	// Selektionswahrscheinlichkeit: Fitness- oder Rangbasiert
		public Helper.Enums.SelType SelType;			// Selektionsverfahren: Roulette, Single-, MultiTournament
		public Helper.Enums.Encryption Encryption;		// Genomkodierung
		public int TournamentMemberCount;				// Anzahl Teilnehmer der Turnierselektion
		
		public double bestFitness;						// Bester Fitnesswert
		public double averageFitness;					// Durchschnittliche Fitness der aktuellen Generation
		public int bestFitnessGeneration;				// Generationzahl, in der bestFitness aufgetreten ist
		
		public int stableGenerations;					// Anzahl an Generationen, in denen sich die beste Fitness nicht geaendert hat
		public List<double> bestSolutions;				// Liste mit den besten Fitnesswerten aus mehreren Durchläufen
		public List<int> bestSolutionsGeneration;		// Liste mit den Generationzahlen, in denen die beste Fitness das erste Mal aufgetreten ist
		
		private StringBuilder sb;
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='problem'>Anzuwendendes Problem</param>
		public Evolution(Problem problem)
		{
			countGene = problem.countGene;
			maxGenerations = problem.maxGenerations;
			countIndividuals = problem.countIndividuals;
			countChilds = problem.countChilds;
			recombinationProbability = problem.recombinationProbability;
			InvertOnMutate = problem.InvertOnMutate;
			minAllelValue = problem.minAllelValue;
			maxAllelValue = problem.maxAllelValue;
			SelPropType = problem.SelPropType;
			SelType = problem.SelType;
			Encryption = problem.Encryption;
			TournamentMemberCount = problem.TournamentMemberCount;
			
			sb = problem.Output;
			
			bestFitness = double.MaxValue;
			averageFitness = double.MaxValue;
			bestFitnessGeneration = 0;
			bestSolutions = new List<double>();
			bestSolutionsGeneration = new List<int>();
			
			switch (Encryption)
			{
				case Helper.Enums.Encryption.None :
				{
					Recombine = problem.RecombineDefault; 
					CalcFitness = problem.CalcFitnessDefault;
					Mutate = problem.MutateDefault;
					break;
				}
				case Helper.Enums.Encryption.Binary :
				{
					Recombine = problem.RecombineBinary;
					CalcFitness = problem.CalcFitnessBinary;				
					Mutate = problem.MutateBinary;
					break;
				}
				case Helper.Enums.Encryption.Real :
				{
					Recombine = problem.RecombineReal;
					CalcFitness = problem.CalcFitnessReal;
					Mutate = problem.MutateReal;
					break;
				}
			}			
		}

		/// <summary>
		/// Der eigentliche evolutionäre Algorithmus - entspricht doc/EvoAlgTSP.pdf.
		/// </summary>
		public void Compute(BackgroundWorker worker)
		{
			int countGeneration = 0;	
			
			bestFitness = double.MaxValue;
			averageFitness = double.MaxValue;
			bestFitnessGeneration = 0;
			Genome bestGenome;
			
			sb.AppendLine("Compute:");
			
			// 1. Initialisiere Population P(0) mit zufälligen Genomen
			Population p = new Population(countIndividuals, countGene, minAllelValue, maxAllelValue, Encryption);
			
			while(countGeneration < maxGenerations && stableGenerations < 1000)
			{	
				//Prozentualer Fortschritte an BackgroundWorker weiter geben
				int percentage = (int)((float)(countGeneration + 1) / (float)maxGenerations * 100);
				worker.ReportProgress(percentage);
				
				// 2. Berechne die Fitnesswerte von P(0)
				foreach (Genome genome in p.curGeneration) {
					CalcFitness(genome);
				}
				if (countGeneration > 0)
					bestGenome = p.curGeneration[0];
				else
					bestGenome = Helper.Fitness.GetBestGenome(p.curGeneration); // p.GetBestGenome();
				
				// Fitness des besten Genoms, ist hoeher als bisherige beste Fitness
				if (bestGenome.Fitness < bestFitness)
				{
					bestFitness = bestGenome.Fitness;
					bestFitnessGeneration = countGeneration + 1;
				} 
				else 
				{
					// Zähle stableGenerations hoch, wenn sich bester Fitnesswert nicht geändert hat
					stableGenerations++;
				}
				
				//alte Generation merken
				p.SaveAsOldGen();

				// 3. Erzeuge Kinder und füge sie P' hinzu
				double rndDouble;
				int c = 0;
				while (c < countChilds) 
				{
					// Zufallszahl zwischen 0 und 1					
					rndDouble = Helper.GetRandomDouble();
					
					if (rndDouble <= recombinationProbability)
					{
						// I.	Rekombination zweier Individuen A und B aus Population P(0)
						//todo: Genom aus der Populationsklasse liefern lassen damit der Genom-Typ immer passt
						Genome mama = new GenomeReal();
						Genome papa = new GenomeReal();
						bool equals = true;
						
						while (equals)
						{						
							switch (SelType)
							{
								case main.Helper.Enums.SelType.Roulette :
									mama = Selection.Roulette(p.oldGeneration, SelPropType);
									papa = Selection.Roulette(p.oldGeneration, SelPropType);
									break;
								case main.Helper.Enums.SelType.SingleTournament :
									mama = Selection.SingleTournament(p.oldGeneration, TournamentMemberCount, SelPropType);
									papa = Selection.SingleTournament(p.oldGeneration, TournamentMemberCount, SelPropType);
									break;
								case main.Helper.Enums.SelType.MultiTournament :
									mama = Selection.MultiTournament(p.oldGeneration, TournamentMemberCount, SelPropType);
									papa = Selection.MultiTournament(p.oldGeneration, TournamentMemberCount, SelPropType);
									break;							
							}
							//Mama und Papa dürfen nicht die selben sein, sonst evtl. Duplikat
							if (!mama.IsEqual(papa))
								equals = false;
						}
						
						//Rekombinieren und Fitness berechnen
						List<Genome> childs = Recombine(mama,papa);
						foreach (Genome genome in childs)
							CalcFitness(genome);
						
						// II.	Mutiere Kind c
						Mutate(childs);
						
						// III.	Füge Kinder C zu P' hinzu
						if (!p.ContainsGenome(childs[0]))
						{
							p.curGeneration.AddRange(childs);
							c++;
						}
					}
				}
				
				// 5. Erzeuge Kind-Population -> die besten Individuen aus P' + P(0)
				Selection.Plus(p, countIndividuals);
				//todo: Selection.Comma(p, countIndividuals);
				
				countGeneration++;
			}

			//Ausgabe der besten Genome
			sb.AppendLine("Letzte Generation");
			List<Genome> bestGenomes = p.curGeneration.Distinct().ToList();
			foreach (Genome genome in bestGenomes)
				sb.AppendLine(genome.AsString());
			
			// Speichere den besten Fitnesswert und die Generation in der er aufgetreten ist zur späteren Auswertung
			bestSolutions.Add(bestFitness);
			bestSolutionsGeneration.Add(bestFitnessGeneration);
		}
		
		/// <summary>
		/// Ausgabe der durchschnittlichen besten Fitness + Generation aus mehreren Durchläufen
		/// </summary>
		public void GetStats()
		{
			double bestAverageFitness = 0;
			double bestAverageGenerations = 0;
			
			for (int i = 0; i < bestSolutions.Count; i++)
			{
				bestAverageFitness += bestSolutions[i];
				bestAverageGenerations += bestSolutionsGeneration[i];
			}
			bestAverageFitness = bestAverageFitness / bestSolutions.Count;
			bestAverageGenerations = bestAverageGenerations / bestSolutionsGeneration.Count;
			
			Console.WriteLine(String.Format("Beste Lösungen je Durchgang: {0}\r\nAufgetreten in Generation: {1}", Helper.ListToString(bestSolutions), Helper.ListToString(bestSolutionsGeneration)));
			Console.WriteLine(String.Format("Durchschnittliche Fitness: {0}\r\nDurchschnittliche Generation: {1}", bestAverageFitness, bestAverageGenerations));
		}	
	}
}

