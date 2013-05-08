using System;

namespace main
{
	public class TestBinary : Problem
	{
		public TestBinary ()
		{
		}

		#region implemented abstract members of main.Problem
		public override System.Collections.Generic.List<Genome> RecombineDefault (Genome genomeA, Genome genomeB)
		{
			throw new NotImplementedException ();
		}

		public override void CalcFitnessDefault (Genome genome)
		{
			throw new NotImplementedException ();
		}
		#endregion

		#region implemented abstract members of main.Problem
		public override void MutateDefault (System.Collections.Generic.List<Genome> genomes)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

