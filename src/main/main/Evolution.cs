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
		public Gtk.TextView output;
		
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
			SelPropType = problem.SelPropType;
			SelType = problem.SelType;
			Encryption = problem.Encryption;
			TournamentMemberCount = problem.TournamentMemberCount;
			
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
			int countGeneration;	
			
			output.Buffer.Text = "Compute:\r\n";
			
			Genome bestGenome;
			
			// 1. Initialisiere Population P(0) mit zufälligen Genomen
			Population p = new Population(countIndividuals, countGene, Encryption);
			
			for (countGeneration = 0; countGeneration < maxGenerations; countGeneration++)
			{	
				// 2. Berechne die Fitnesswerte von P(0)
				foreach (Genome genome in p.curGeneration) {
					CalcFitness(genome);
				}

				output.Buffer.Text += string.Format("\r\nDurchlauf: {0}\r\n", countGeneration + 1);
				output.Buffer.Text += string.Format("\tAktuelle Population (Count: {1}): \r\n{0}", p.CurrentGenerationAsString(), p.curGeneration.Count());

				bestGenome = Helper.Fitness.GetBestGenome(p.curGeneration); // p.GetBestGenome();
				
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
			}

			//Ausgabe der besten Genome
			//todo: Distinct funzt nich
			output.Buffer.Text += "\r\nBestenliste\r\n";
			List<Genome> bestGenomes = p.curGeneration.Distinct().ToList();
			foreach (Genome genome in bestGenomes) {
				output.Buffer.Text += genome.AsString() + "\r\n";
			}
		}
	}
}

