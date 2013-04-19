using System;
using System.Collections.Generic;
using System.Linq;

namespace main
{
	public class TravelingSalesMan : Problem
	{
		public TravelingSalesMan ()
		{
		}
		
		public override List<Genome> RecombineDefault (Genome genomeA, Genome genomeB)
		{
			//Fehler, wenn Genome null
			if (genomeA == null || genomeB == null) {
				throw new ArgumentNullException();
			}
			//Fehler, wenn Längen der Genome unterschiedlich
			if (genomeA.Count != genomeB.Count) {
				throw new ArgumentException("Cant recombine genomes with a different count of values.");
			}

			//Kinder-List mit Startallel initialisieren
			Genome childs = new GenomeReal();
			childs.Add(genomeA[0]);
				
			//Nachbarn für alle Allele ermitteln
	
			Dictionary<int, Genome> neighbours = new Dictionary<int, Genome>();
			foreach (int gene in genomeA)
			{
				neighbours.Add(gene, GetNeighboursOfValue(gene, genomeA,genomeB));
			}
				
			//Kind ermitteln
			int tempAllel = 0;
			//Alle Allele durchgehen
			int j = 0;
			int g = 1;
			while (j < genomeA.Count - 1)
			{
				int minLength = int.MaxValue;
				foreach (int i in neighbours[g])
				{
					Genome subNeighbours = neighbours[i].Copy();
					subNeighbours.RemoveAll(s => childs.Contains(s));
					//Immer wenn eine kürzere Nachbarmenge gefunden wurde -> das zugehörige Allel merken, insofern noch nicht im Kind vorhanden
					if (subNeighbours.Count < minLength && !childs.Contains(i)) {
						tempAllel = i;
						//Neue kürzeste Länge merken die es zu unterbieten gilt
						minLength = subNeighbours.Count;
					}
				}
				//Ermitteltes Allel zum Kind hinzufügen
				childs.Add(tempAllel);
				g = tempAllel;
				j++;
			}
			
			List<Genome> result = new List<Genome>();
			result.Add(childs);
			return result;
		}
			
		/// <summary>
		/// Ermittelt alle Nachbarn aus zwei Genomen für ein bestimmtes Allel
		/// </summary>
		/// <returns>Liste mit Nachbarn</returns>
		/// <param name="value">Allel</param>
		/// <param name="genomeA">Genome A</param>
		/// <param name="genomeB">Genome B</param>
		private Genome GetNeighboursOfValue (int value, Genome genomeA, Genome genomeB)
		{	
			//Kreisgenom simulieren
			List<int> a = genomeA.ToList();
			a.Insert(0,genomeA[genomeA.Count-1]);
			a.Add(genomeA[0]);
			List<int> b = genomeB.ToList();
			b.Insert(0,genomeB[genomeB.Count-1]);
			b.Add(genomeB[0]);

			//Nachbarn
			Genome neighbours = new Genome();
			neighbours.Add(a[genomeA.IndexOf(value)]);
			neighbours.Add(a[genomeA.IndexOf(value)+2]);
			neighbours.Add(b[genomeB.IndexOf(value)]);
			neighbours.Add(b[genomeB.IndexOf(value)+2]);

			//Doppelte Einträge entfernen und ab damit
			return new GenomeReal(neighbours.Distinct().ToArray());
		}
		
		public override void CalcFitnessDefault (Genome genome)
		{
			genome.Fitness = 0;
			Genome tempGenome = genome.Copy();
			tempGenome.Add(1);
			
			int[,] matrix = new int[,]
							 {
								{ 0,  5,  8, 11,  4,  7 },
								{ 5,  0, 10,  4,  9, 12 },
								{ 8, 10,  0,  6, 17,  8 },
								{11,  4,  6,  0,  6,  5 },
								{ 4,  9, 17,  6,  0, 11 },
								{ 7, 12,  8,  5, 11,  0 }
							 };
			
			foreach (int gene in genome) {
				genome.Fitness += matrix[gene - 1,tempGenome[tempGenome.IndexOf(gene)+1]-1];
			}
		}
	}
}

