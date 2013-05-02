using System;
using Gtk;
using System.Collections.Generic;
using main;
using System.Linq;

public partial class MainWindow: Gtk.Window
{		
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		OnCboEncryptionChanged(cbo_Encryption, null);
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnStartClicked (object sender, EventArgs e)
	{
		/*
		List<int> a = new List<int>() {1,2,3,4,8,5,6,7};
		List<int> b = new List<int>() {1,4,8,6,5,7,2,3};
		
		a = Evolution.Mutate(a);
		List<int> c = Evolution.Recombine(a,b);
		
		// für Fehlersuche: x sollte { 1, 3, 8, 4, 4, 2, 6, 7 } sein
		Genome z = new Genome(new int[]{1,5,8,4,3,2,6,7});
		Genome y = new Genome(new int[]{1,4,8,6,5,7,2,3});
		Genome x = Evolution.Recombine(z,y);
		
		// Beispiel aus der Vorlesung
		Genome z = new Genome(new int[]{1,2,3,4,8,5,6,7});
		Genome y = new Genome(new int[]{1,4,8,6,5,7,2,3});
		Genome x = Evolution.Recombine(z,y);
		
		//List<int> d = Genome.GetNewGenome(8);
		
		Console.WriteLine("Create new Population:");
		Population p0 = new Population(100, 8);
		*/
		try
		{
			Problem problem = null;
			
			switch (cbo_Problem.Active)
			{
				case 0 :	problem = new TravelingSalesMan(); break;
				case 1 :	problem = new Griewank(); break;
	//			case 2 :	problem = new TravelingSalesMan(); break;
			}
			
			if (problem == null)
				throw new NullReferenceException();
			
			problem.countGene = (int)txt_countGenes.Value;
			problem.maxGenerations = (int)txt_maxGeneration.Value;
			problem.countIndividuals = (int)txt_countIndividuals.Value;
			problem.countChilds = (int)txt_countChilds.Value;
			problem.recombinationProbability = txt_recombProb.Value;
		
			//todo, in Oberfläche bauen
			if (cbo_Encryption.Active == 1)
			{
				problem.RecombBinaryIsSinglePoint = cbo_recombBinary.Active == 0;
			}
			if (cbo_Encryption.Active == 2)
			{
				problem.RecombRealIsIntermidiate = cbo_recombReal.Active == 0;
			}
		
			problem.InvertOnMutate = rb_Invert.Active ? true : false;
		
			problem.minAllelValue = problem.minAllelValue == 0 ? 1 : problem.minAllelValue;
			problem.maxAllelValue = problem.maxAllelValue == 0 ? problem.countGene + 1 : problem.maxAllelValue;
		
			problem.SelPropType = rb_Fitness.Active ? main.Helper.Enums.SelPropType.Fitness : main.Helper.Enums.SelPropType.Ranking;
			problem.SelType = (main.Helper.Enums.SelType)cbo_SelType.Active;
			problem.Encryption = (main.Helper.Enums.Encryption)cbo_Encryption.Active;	
			problem.TournamentMemberCount = (int)txt_TournamentMemberCount.Value;
							
			Evolution evol = new Evolution(problem);
			evol.output = txt_Output;
			
			evol.Compute();
		}
		catch (Exception ex)
		{
			txt_Output.Buffer.Text += "\r\n\r\nFehler: " + ex.Message + "\r\n\r\n" + ex.StackTrace;
		}
	}

	protected void OnCboSelTypeChanged (object sender, System.EventArgs e)
	{
		txt_TournamentMemberCount.Sensitive = cbo_SelType.Active > 0;
	}

	protected void OnBtnStart10Clicked (object sender, System.EventArgs e)
	{
		Problem problem = null;
			
			switch (cbo_Problem.Active)
			{
				case 0 :	problem = new TravelingSalesMan(); break;
	//			case 1 :	problem = new TravelingSalesMan(); break;
	//			case 2 :	problem = new TravelingSalesMan(); break;
			}
			
			if (problem == null)
				throw new NullReferenceException();
			
			problem.countGene = (int)txt_countGenes.Value;
			problem.maxGenerations = (int)txt_maxGeneration.Value;
			problem.countIndividuals = (int)txt_countIndividuals.Value;
			problem.countChilds = (int)txt_countChilds.Value;
			problem.recombinationProbability = txt_recombProb.Value;
			problem.InvertOnMutate = rb_Invert.Active ? true : false;
			problem.SelPropType = rb_Fitness.Active ? main.Helper.Enums.SelPropType.Fitness : main.Helper.Enums.SelPropType.Ranking;
			problem.SelType = (main.Helper.Enums.SelType)cbo_SelType.Active;
			problem.Encryption = (main.Helper.Enums.Encryption)cbo_Encryption.Active;	
			problem.TournamentMemberCount = (int)txt_TournamentMemberCount.Value;
					
			Evolution evol = new Evolution(problem);
			evol.output = txt_Output;
			
			
			for(int i = 0; i < 10; i++)
			{
				evol.Compute();
			}
			evol.GetStats();
	}

	protected void OnCboEncryptionChanged (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
		
		pnl_recombEncrypt.Sensitive = false;
		cbo_recombBinary.Visible = false;
		cbo_recombReal.Visible = false;
		
		switch (cbo_Encryption.Active) {
			case 0:	break;
			case 1:	
			{
				pnl_recombEncrypt.Sensitive = true;
				cbo_recombBinary.Visible = true;
				break;
			}
			case 2:
			{
				pnl_recombEncrypt.Sensitive = true;
				cbo_recombReal.Visible = true;
				break;
			}
		}		
		
	}
}
