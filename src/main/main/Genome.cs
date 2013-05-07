using System;
using System.Collections.Generic;

namespace main
{
	public class Genome : List<double>
	{		
		private double _Fitness;
		private double _SelectionProbability;
		
		public double Fitness {
			get {
				return _Fitness;
			}
			set { _Fitness = value; }
		}
		
		public double SelectionProbability {
			get {
				return _SelectionProbability;
			}
			set {
				_SelectionProbability = value;
			}
		}	
		
		public Genome ()
		{
			
		}
		
		public Genome(int size)
		{
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name='arr'>Integer Array, mit dem Genom initialisiert wird</param>
		public Genome (double[] arr)
		{
			this.Clear();
			this.AddRange(arr);
		}
				
		public bool IsEqual (Genome genome)
		{
			for (int i = 0; i < genome.Count -1; i++) 
			{
				if (this[i] != genome[i])
				    return false;
			}
			return true;
		}
		
		/// <summary>
		/// Convertiert den Inhalt eines Genoms in einen String.
		/// </summary>
		/// <returns>Inhalt als String</returns>
		/// <param name="list">Zu konvertierendes Genom</param>
		public string AsString()
		{
			string tmp = "{";
			string sep = string.Empty;
			foreach (double i in this) {
				tmp = string.Format("{0}{1} {2}", tmp, sep, i);
				sep = ",";
			}
			tmp = string.Format("{0} }} Fitness: {1}", tmp, _Fitness);
			return tmp;
		}
		
		/// <summary>
		/// Kopiert ein Genom
		/// </summary>
		public virtual Genome Copy()
		{
			throw new NotImplementedException();
		}
	}
}

