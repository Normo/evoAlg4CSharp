using System;
using Gtk;
using System.Collections.Generic;
using main;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;

public partial class MainWindow: Gtk.Window
{		
	private BackgroundWorker worker;
	private Stopwatch watch;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		OnCboEncryptionChanged(cbo_Encryption, null);
		watch = new Stopwatch();
	}	
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnStartClicked (object sender, EventArgs e)
	{		
		btn_Start.Sensitive = false;
		txt_Output.Buffer.Clear();
		try
		{
			Problem problem = null;
			
			switch (cbo_Problem.Active)
			{
				case 0 :	problem = new TravelingSalesMan(); break;
				case 1 :	problem = new Griewank(); break;
				case 2 :	problem = new Ackley(); break;
			}
			
			if (problem == null)
				throw new NullReferenceException();
			
			problem.countGene = (int)txt_countGenes.Value;
			problem.maxGenerations = (int)txt_maxGeneration.Value;
			problem.countIndividuals = (int)txt_countIndividuals.Value;
			problem.countChilds = (int)txt_countChilds.Value;
			problem.recombinationProbability = txt_recombProb.Value;
			
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
			
			//Methode zum behandeln des Fortschritt-Events zuweisen
			evol.OnProgress += new Evolution.OnProgressEvent(OnEvolutionProgressChanged);
			
			// Laufzeitmessung
			watch.Start();
			
			evol.Compute();
			
			//Laufzeitauswertung
			watch.Reset();
			
			txt_Output.Buffer.Text = problem.Output.ToString();
			
			btn_Start.Sensitive = true;
		}
		catch (Exception ex)
		{
			txt_Output.Buffer.Text += "\r\n\r\nFehler: " + ex.Message + "\r\n\r\n" + ex.StackTrace;
			btn_Start.Sensitive = true;
		}
	}
	
	protected void OnEvolutionProgressChanged(double percentage)
	{
		progressbar.Fraction = percentage;
		progressbar.Text = string.Format ("{0:0.00} %", percentage * 100);
		statusbar.Push(1,"Laufzeit: " + watch.Elapsed);
	}

	protected void OnCboSelTypeChanged (object sender, System.EventArgs e)
	{
		txt_TournamentMemberCount.Sensitive = cbo_SelType.Active > 0;
	}

	protected void OnBtnStart10Clicked (object sender, System.EventArgs e)
	{
		//Mal ne Exception, will ich eh alles anders machen
		statusbar.Push(1,"Ditt jeht noch nich, keule.");
		Problem bin = new Griewank();
		bin.MutateBinary(null);
	}

	protected void OnCboEncryptionChanged (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
		
		pnl_MutationType.Visible = false;
		pnl_recombEncrypt.Sensitive = false;
		cbo_recombBinary.Visible = false;
		cbo_recombReal.Visible = false;
		
		switch (cbo_Encryption.Active) {
			case 0:
			{
				pnl_MutationType.Visible = true;
				break;
			}
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
