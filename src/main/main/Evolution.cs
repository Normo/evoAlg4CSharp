using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gtk;

namespace main
{
	public class Evolution
	{
		public delegate List<Genome> RecombineMethod (Genome genomeA, Genome genomeB);
		public delegate void FitnessMethod (Genome genome);
		
		public RecombineMethod Recombine;
		public FitnessMethod CalcFitness;
		
		public int countGene;							// Anzahl der Gene
		public int maxGenerations;						// Maximale Anzahl zu erzeugender Generationen
		public int countIndividuals;					// Anzahl an Individuen einer Population
		public int countChilds;							// Anzahl zu erzeugender Kinder
		public double recombinationProbability;			// Rekombinationswahrscheinlichkeit
		public bool InvertOnMutate;						// Mutation: true = invertieren, false = tauschen
		public int minAllelValue;						// Minimaler Wert der Allele
		public int maxAllelValue;						// Maximaler Wert der Allele
		public Helper.Enums.SelPropType SelPropType;	// Selektionswahrscheinlichkeit: Fitness- oder Rangbasiert
		public Helper.Enums.SelType SelType;			// Selektionsverfahren: Roulette, Single-, MultiTournament
		public Helper.Enums.Encryption Encryption;		// Genomkodierung
		public int TournamentMemberCount;				// Anzahl Teilnehmer der Turnierselektion
		public Gtk.TextView output;						// Textbox Objekt
		
		public double bestFitness;						// Bester Fitnesswert
		public double averageFitness;					// Durchschnittliche Fitness der aktuellen Generation
		public int bestFitnessGeneration;				// Generationzahl, in der bestFitness aufgetreten ist
		
		public int stableGenerations;					// Anzahl an Generationen, in denen sich die beste Fitness nicht geaendert hat
		public List<double> bestSolutions;				// Liste mit den besten Fitnesswerten aus mehreren Durchläufen
		public List<int> bestSolutionsGeneration;		// Liste mit den Generationzahlen, in denen die beste Fitness das erste Mal aufgetreten ist
		
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
					break;
				}
//				case Helper.Enums.Encryption.Binary :
//				{
//					Recombine = problem.RecombineBinary;
//					CalcFitness = problem.CalcFitnessBinary;
//					break;
//				}
//				case Helper.Enums.Encryption.Real :
//				{
//					Recombine = problem.RecombineReal;
//					CalcFitness = problem.CalcFitnessReal;
//					break;
//				}
			}			
		}
		
		/// <summary>
		/// Mutiert ein Genom
		/// </summary>
		/// <param name="genome">Das Genome, was mutiert werden soll</param>
		private void Mutate (List<Genome> genomes) 
		{
			foreach (Genome genome in genomes)
			{				
				int z1 = 0;
				int z2 = 0;
				int tmp = 0;
				int length = genome.Count;
				bool equal = true;
	
				//Zwei verschiedene Zufallsindices ermitteln
				while (equal)
				{
					//Von Index 1 an da sich der erste Wert (index 0) nicht ändern soll
					z1 = Helper.GetRandomInteger(1, length-1);
					z2 = Helper.GetRandomInteger(1, length-1);
					if (z1 != z2 )
						equal = false;
				}
	
				// Wenn true, invertiere, sonst, tausche
				if (InvertOnMutate) 
				{
					tmp = z1 < z2 ? z1 : z2;
					genome.Reverse(tmp, Math.Abs(z1-z2)+1);
				}
				else
				{
					tmp = genome[z1];
					genome[z1] = genome[z2];
					genome[z2] = tmp;
				}
			}
			return;
		}
		
		/// <summary>
		/// Der eigentliche evolutionäre Algorithmus - entspricht doc/EvoAlgTSP.pdf.
		/// </summary>
		public void Compute()
		{
			int countGeneration = 0;	
			
			bestFitness = double.MaxValue;
			averageFitness = double.MaxValue;
			bestFitnessGeneration = 0;
			
			output.Buffer.Text = "Compute:\r\n";
			
			Genome bestGenome;
			
			// 1. Initialisiere Population P(0) mit zufälligen Genomen
			Population p = new Population(countIndividuals, countGene, minAllelValue, maxAllelValue, Encryption);
			
			while(countGeneration < maxGenerations && stableGenerations < 1000)
			//for (countGeneration = 0; countGeneration < maxGenerations; countGeneration++)
			{	
				// 2. Berechne die Fitnesswerte von P(0)
				foreach (Genome genome in p.curGeneration) {
					CalcFitness(genome);
				}
				
				output.Buffer.Text += string.Format("\r\nGeneration: {0}\r\n", countGeneration + 1);
				output.Buffer.Text += string.Format("\tAktuelle Population (Count: {1}): \r\n{0}", p.CurrentGenerationAsString(), p.curGeneration.Count());

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
				
				//output.Buffer.Text += string.Format("\tBeste Fitness {0}\r\n", bestGenome.Fitness);
				output.Buffer.Text += string.Format("\tBestes Genom {0}\r\n", bestGenome.AsString());
				
				// Berechne Durchschnittsfitnesswert der aktuellen Generation
				output.Buffer.Text += string.Format("\tDurchschnittliche Fitness {0}\r\n", Helper.Fitness.GetAverageFitness(p.curGeneration));
			
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
						List<Genome> childs = Recombine(mama,papa);

						// II.	Mutiere Kind c
						Mutate(childs);
						
						// III.	Füge Kinder C zu P' hinzu
						if (!p.oldGeneration.Contains(childs[0]) || !p.curGeneration.Contains(childs[0]))
						p.curGeneration.AddRange(childs);
						
						c++;
					}
				}
				
				// 4. Berechne die Fitness von P'
				foreach (Genome genome in p.curGeneration) {
					CalcFitness(genome);
				}
				
				// 5. Erzeuge Kind-Population -> die besten Individuen aus P' + P(0)
				Selection.Plus(p, countIndividuals);
				//todo: Selection.Comma(p, countIndividuals);
				
				countGeneration++;
			}

			//Ausgabe der besten Genome
			//todo: Distinct funzt nich
			output.Buffer.Text += "\r\nBestenliste\r\n";
			List<Genome> bestGenomes = p.curGeneration.Distinct().ToList();
			foreach (Genome genome in bestGenomes) {
				output.Buffer.Text += genome.AsString() + "\r\n";
			}
			
			// Konsolenausgabe der Endergebnisse
			//Console.WriteLine(String.Format("Beste Fitness: {0}\r\nGeneration: {1}", bestFitness, bestFitnessGeneration));
			
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
			
			Console.WriteLine(String.Format("BestSolutions: {0}\r\nBestSolutionsGeneration: {1}", Helper.ListToString(bestSolutions), Helper.ListToString(bestSolutionsGeneration)));
			Console.WriteLine(String.Format("Durchschnittliche Fitness: {0}\r\nDurchschnittliche Generation: {1}", bestAverageFitness, bestAverageGenerations));
		}			
	}
}

