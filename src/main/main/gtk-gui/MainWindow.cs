
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox_main;
	private global::Gtk.HPaned pnl_mainWidget;
	private global::Gtk.VBox vbox_left;
	private global::Gtk.Frame frame4;
	private global::Gtk.Alignment GtkAlignment3;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView txt_Output;
	private global::Gtk.Label GtkLabel10;
	private global::Gtk.VBox vbox_right;
	private global::Gtk.Notebook mainTabWidget;
	private global::Gtk.VBox vbox_TabProblem;
	private global::Gtk.Frame frame_ProblemArt;
	private global::Gtk.Alignment GtkAlignment4;
	private global::Gtk.VBox vbox_ProblemArt;
	private global::Gtk.ComboBox cbo_Problem;
	private global::Gtk.Label GtkLabel;
	private global::Gtk.Frame frame_Kodierung;
	private global::Gtk.Alignment GtkAlignment5;
	private global::Gtk.VBox vbox_Kodierung;
	private global::Gtk.ComboBox cbo_Encryption;
	private global::Gtk.Label GtkLabel11;
	private global::Gtk.Label label1;
	private global::Gtk.VBox vbox_TabEigenschaften;
	private global::Gtk.Frame frame_Population;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label label2;
	private global::Gtk.SpinButton txt_countIndividuals;
	private global::Gtk.HBox hbox8;
	private global::Gtk.Label label4;
	private global::Gtk.SpinButton txt_maxGeneration;
	private global::Gtk.HBox hbox9;
	private global::Gtk.Label label5;
	private global::Gtk.SpinButton txt_countChilds;
	private global::Gtk.HBox hbox10;
	private global::Gtk.Label label6;
	private global::Gtk.SpinButton txt_recombProb;
	private global::Gtk.Label GtkLabel1;
	private global::Gtk.Frame frame_Genom;
	private global::Gtk.VBox vbox4;
	private global::Gtk.HBox hbox11;
	private global::Gtk.Label label7;
	private global::Gtk.SpinButton txt_countGenes;
	private global::Gtk.Label GtkLabel2;
	private global::Gtk.Frame frame_Evolution;
	private global::Gtk.Alignment GtkAlignment2;
	private global::Gtk.VBox vbox6;
	private global::Gtk.HBox pnl_MutationType;
	private global::Gtk.Label label8;
	private global::Gtk.RadioButton rb_Change;
	private global::Gtk.RadioButton rb_Invert;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label label9;
	private global::Gtk.RadioButton rb_Fitness;
	private global::Gtk.RadioButton rb_Rank;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Label label10;
	private global::Gtk.ComboBox cbo_SelType;
	private global::Gtk.SpinButton txt_TournamentMemberCount;
	private global::Gtk.HBox pnl_recombEncrypt;
	private global::Gtk.Label lbl_Recombination;
	private global::Gtk.ComboBox cbo_recombBinary;
	private global::Gtk.ComboBox cbo_recombReal;
	private global::Gtk.Label GtkLabel9;
	private global::Gtk.Label label11;
	private global::Gtk.Button btn_Start;
	private global::Gtk.Button btn_Start10;
	private global::Gtk.Statusbar statusbar;
	private global::Gtk.ProgressBar progressbar;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.AllowShrink = true;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox_main = new global::Gtk.VBox ();
		this.vbox_main.Name = "vbox_main";
		this.vbox_main.Spacing = 6;
		// Container child vbox_main.Gtk.Box+BoxChild
		this.pnl_mainWidget = new global::Gtk.HPaned ();
		this.pnl_mainWidget.CanDefault = true;
		this.pnl_mainWidget.CanFocus = true;
		this.pnl_mainWidget.Name = "pnl_mainWidget";
		this.pnl_mainWidget.Position = 382;
		// Container child pnl_mainWidget.Gtk.Paned+PanedChild
		this.vbox_left = new global::Gtk.VBox ();
		this.vbox_left.WidthRequest = 382;
		this.vbox_left.Name = "vbox_left";
		this.vbox_left.Homogeneous = true;
		this.vbox_left.Spacing = 6;
		// Container child vbox_left.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame4.BorderWidth = ((uint)(1));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txt_Output = new global::Gtk.TextView ();
		this.txt_Output.CanFocus = true;
		this.txt_Output.Name = "txt_Output";
		this.txt_Output.AcceptsTab = false;
		this.GtkScrolledWindow.Add (this.txt_Output);
		this.GtkAlignment3.Add (this.GtkScrolledWindow);
		this.frame4.Add (this.GtkAlignment3);
		this.GtkLabel10 = new global::Gtk.Label ();
		this.GtkLabel10.Name = "GtkLabel10";
		this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Ausgabe</b>");
		this.GtkLabel10.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel10;
		this.vbox_left.Add (this.frame4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox_left [this.frame4]));
		w4.Position = 1;
		this.pnl_mainWidget.Add (this.vbox_left);
		global::Gtk.Paned.PanedChild w5 = ((global::Gtk.Paned.PanedChild)(this.pnl_mainWidget [this.vbox_left]));
		w5.Resize = false;
		// Container child pnl_mainWidget.Gtk.Paned+PanedChild
		this.vbox_right = new global::Gtk.VBox ();
		this.vbox_right.Name = "vbox_right";
		this.vbox_right.Spacing = 6;
		// Container child vbox_right.Gtk.Box+BoxChild
		this.mainTabWidget = new global::Gtk.Notebook ();
		this.mainTabWidget.CanFocus = true;
		this.mainTabWidget.Name = "mainTabWidget";
		this.mainTabWidget.CurrentPage = 1;
		// Container child mainTabWidget.Gtk.Notebook+NotebookChild
		this.vbox_TabProblem = new global::Gtk.VBox ();
		this.vbox_TabProblem.Name = "vbox_TabProblem";
		this.vbox_TabProblem.Spacing = 6;
		// Container child vbox_TabProblem.Gtk.Box+BoxChild
		this.frame_ProblemArt = new global::Gtk.Frame ();
		this.frame_ProblemArt.Name = "frame_ProblemArt";
		this.frame_ProblemArt.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame_ProblemArt.BorderWidth = ((uint)(1));
		// Container child frame_ProblemArt.Gtk.Container+ContainerChild
		this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment4.Name = "GtkAlignment4";
		this.GtkAlignment4.LeftPadding = ((uint)(12));
		// Container child GtkAlignment4.Gtk.Container+ContainerChild
		this.vbox_ProblemArt = new global::Gtk.VBox ();
		this.vbox_ProblemArt.Name = "vbox_ProblemArt";
		this.vbox_ProblemArt.Spacing = 6;
		// Container child vbox_ProblemArt.Gtk.Box+BoxChild
		this.cbo_Problem = global::Gtk.ComboBox.NewText ();
		this.cbo_Problem.AppendText (global::Mono.Unix.Catalog.GetString ("Traveling Salesman"));
		this.cbo_Problem.AppendText (global::Mono.Unix.Catalog.GetString ("Griewank"));
		this.cbo_Problem.AppendText (global::Mono.Unix.Catalog.GetString ("Ackley"));
		this.cbo_Problem.Name = "cbo_Problem";
		this.cbo_Problem.Active = 1;
		this.vbox_ProblemArt.Add (this.cbo_Problem);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox_ProblemArt [this.cbo_Problem]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		this.GtkAlignment4.Add (this.vbox_ProblemArt);
		this.frame_ProblemArt.Add (this.GtkAlignment4);
		this.GtkLabel = new global::Gtk.Label ();
		this.GtkLabel.Name = "GtkLabel";
		this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Art</b>");
		this.GtkLabel.UseMarkup = true;
		this.frame_ProblemArt.LabelWidget = this.GtkLabel;
		this.vbox_TabProblem.Add (this.frame_ProblemArt);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox_TabProblem [this.frame_ProblemArt]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox_TabProblem.Gtk.Box+BoxChild
		this.frame_Kodierung = new global::Gtk.Frame ();
		this.frame_Kodierung.Name = "frame_Kodierung";
		this.frame_Kodierung.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame_Kodierung.BorderWidth = ((uint)(1));
		// Container child frame_Kodierung.Gtk.Container+ContainerChild
		this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment5.Name = "GtkAlignment5";
		this.GtkAlignment5.LeftPadding = ((uint)(12));
		// Container child GtkAlignment5.Gtk.Container+ContainerChild
		this.vbox_Kodierung = new global::Gtk.VBox ();
		this.vbox_Kodierung.Name = "vbox_Kodierung";
		this.vbox_Kodierung.Spacing = 6;
		// Container child vbox_Kodierung.Gtk.Box+BoxChild
		this.cbo_Encryption = global::Gtk.ComboBox.NewText ();
		this.cbo_Encryption.AppendText (global::Mono.Unix.Catalog.GetString ("ohne"));
		this.cbo_Encryption.AppendText (global::Mono.Unix.Catalog.GetString ("Binär"));
		this.cbo_Encryption.AppendText (global::Mono.Unix.Catalog.GetString ("Reell"));
		this.cbo_Encryption.Name = "cbo_Encryption";
		this.cbo_Encryption.Active = 2;
		this.vbox_Kodierung.Add (this.cbo_Encryption);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox_Kodierung [this.cbo_Encryption]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		this.GtkAlignment5.Add (this.vbox_Kodierung);
		this.frame_Kodierung.Add (this.GtkAlignment5);
		this.GtkLabel11 = new global::Gtk.Label ();
		this.GtkLabel11.Name = "GtkLabel11";
		this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Kodierung</b>");
		this.GtkLabel11.UseMarkup = true;
		this.frame_Kodierung.LabelWidget = this.GtkLabel11;
		this.vbox_TabProblem.Add (this.frame_Kodierung);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox_TabProblem [this.frame_Kodierung]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.mainTabWidget.Add (this.vbox_TabProblem);
		// Notebook tab
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Problem</b>");
		this.label1.UseMarkup = true;
		this.mainTabWidget.SetTabLabel (this.vbox_TabProblem, this.label1);
		this.label1.ShowAll ();
		// Container child mainTabWidget.Gtk.Notebook+NotebookChild
		this.vbox_TabEigenschaften = new global::Gtk.VBox ();
		this.vbox_TabEigenschaften.Name = "vbox_TabEigenschaften";
		this.vbox_TabEigenschaften.Spacing = 6;
		// Container child vbox_TabEigenschaften.Gtk.Box+BoxChild
		this.frame_Population = new global::Gtk.Frame ();
		this.frame_Population.Name = "frame_Population";
		this.frame_Population.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame_Population.BorderWidth = ((uint)(1));
		// Container child frame_Population.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.WidthRequest = 141;
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Individuen");
		this.hbox7.Add (this.label2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label2]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.txt_countIndividuals = new global::Gtk.SpinButton (0, 1000, 1);
		this.txt_countIndividuals.CanFocus = true;
		this.txt_countIndividuals.Name = "txt_countIndividuals";
		this.txt_countIndividuals.Adjustment.PageIncrement = 10;
		this.txt_countIndividuals.ClimbRate = 1;
		this.txt_countIndividuals.Numeric = true;
		this.txt_countIndividuals.Value = 150;
		this.hbox7.Add (this.txt_countIndividuals);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.txt_countIndividuals]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox3.Add (this.hbox7);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox7]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.WidthRequest = 141;
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Generationen");
		this.hbox8.Add (this.label4);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label4]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.txt_maxGeneration = new global::Gtk.SpinButton (0, 10000, 1);
		this.txt_maxGeneration.CanFocus = true;
		this.txt_maxGeneration.Name = "txt_maxGeneration";
		this.txt_maxGeneration.Adjustment.PageIncrement = 10;
		this.txt_maxGeneration.ClimbRate = 1;
		this.txt_maxGeneration.Numeric = true;
		this.txt_maxGeneration.Value = 150;
		this.hbox8.Add (this.txt_maxGeneration);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.txt_maxGeneration]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		this.vbox3.Add (this.hbox8);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox8]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox ();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.WidthRequest = 141;
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Nachkommen");
		this.hbox9.Add (this.label5);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label5]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.txt_countChilds = new global::Gtk.SpinButton (0, 1000, 1);
		this.txt_countChilds.CanFocus = true;
		this.txt_countChilds.Name = "txt_countChilds";
		this.txt_countChilds.Adjustment.PageIncrement = 10;
		this.txt_countChilds.ClimbRate = 1;
		this.txt_countChilds.Numeric = true;
		this.txt_countChilds.Value = 200;
		this.hbox9.Add (this.txt_countChilds);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.txt_countChilds]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		this.vbox3.Add (this.hbox9);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox9]));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.WidthRequest = 141;
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Rekomb. Wahrsch.");
		this.hbox10.Add (this.label6);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.label6]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.txt_recombProb = new global::Gtk.SpinButton (0, 1, 0.1);
		this.txt_recombProb.CanFocus = true;
		this.txt_recombProb.Name = "txt_recombProb";
		this.txt_recombProb.Adjustment.PageIncrement = 0.1;
		this.txt_recombProb.ClimbRate = 1;
		this.txt_recombProb.Digits = ((uint)(2));
		this.txt_recombProb.Numeric = true;
		this.txt_recombProb.Value = 0.8;
		this.hbox10.Add (this.txt_recombProb);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.txt_recombProb]));
		w25.Position = 1;
		w25.Expand = false;
		w25.Fill = false;
		this.vbox3.Add (this.hbox10);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox10]));
		w26.Position = 3;
		w26.Expand = false;
		w26.Fill = false;
		this.GtkAlignment.Add (this.vbox3);
		this.frame_Population.Add (this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label ();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Population</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame_Population.LabelWidget = this.GtkLabel1;
		this.vbox_TabEigenschaften.Add (this.frame_Population);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox_TabEigenschaften [this.frame_Population]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox_TabEigenschaften.Gtk.Box+BoxChild
		this.frame_Genom = new global::Gtk.Frame ();
		this.frame_Genom.Name = "frame_Genom";
		this.frame_Genom.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame_Genom.BorderWidth = ((uint)(1));
		// Container child frame_Genom.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.WidthRequest = 153;
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Gene");
		this.hbox11.Add (this.label7);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label7]));
		w30.Position = 0;
		w30.Expand = false;
		w30.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.txt_countGenes = new global::Gtk.SpinButton (0, 100, 1);
		this.txt_countGenes.CanFocus = true;
		this.txt_countGenes.Name = "txt_countGenes";
		this.txt_countGenes.Adjustment.PageIncrement = 10;
		this.txt_countGenes.ClimbRate = 1;
		this.txt_countGenes.Numeric = true;
		this.txt_countGenes.Value = 6;
		this.hbox11.Add (this.txt_countGenes);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.txt_countGenes]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		this.vbox4.Add (this.hbox11);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox11]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		this.frame_Genom.Add (this.vbox4);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Genom</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame_Genom.LabelWidget = this.GtkLabel2;
		this.vbox_TabEigenschaften.Add (this.frame_Genom);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox_TabEigenschaften [this.frame_Genom]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox_TabEigenschaften.Gtk.Box+BoxChild
		this.frame_Evolution = new global::Gtk.Frame ();
		this.frame_Evolution.Name = "frame_Evolution";
		this.frame_Evolution.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame_Evolution.BorderWidth = ((uint)(1));
		// Container child frame_Evolution.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.pnl_MutationType = new global::Gtk.HBox ();
		this.pnl_MutationType.Name = "pnl_MutationType";
		this.pnl_MutationType.Spacing = 6;
		// Container child pnl_MutationType.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.WidthRequest = 106;
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Mutation");
		this.pnl_MutationType.Add (this.label8);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.pnl_MutationType [this.label8]));
		w35.Position = 0;
		w35.Expand = false;
		w35.Fill = false;
		// Container child pnl_MutationType.Gtk.Box+BoxChild
		this.rb_Change = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Tauschen"));
		this.rb_Change.CanFocus = true;
		this.rb_Change.Name = "rb_Change";
		this.rb_Change.DrawIndicator = true;
		this.rb_Change.UseUnderline = true;
		this.rb_Change.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.pnl_MutationType.Add (this.rb_Change);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.pnl_MutationType [this.rb_Change]));
		w36.Position = 1;
		// Container child pnl_MutationType.Gtk.Box+BoxChild
		this.rb_Invert = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Invertieren"));
		this.rb_Invert.CanFocus = true;
		this.rb_Invert.Name = "rb_Invert";
		this.rb_Invert.DrawIndicator = true;
		this.rb_Invert.UseUnderline = true;
		this.rb_Invert.Group = this.rb_Change.Group;
		this.pnl_MutationType.Add (this.rb_Invert);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.pnl_MutationType [this.rb_Invert]));
		w37.Position = 2;
		this.vbox6.Add (this.pnl_MutationType);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.pnl_MutationType]));
		w38.Position = 0;
		w38.Expand = false;
		w38.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Zufallsselektion");
		this.hbox5.Add (this.label9);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label9]));
		w39.Position = 0;
		w39.Expand = false;
		w39.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.rb_Fitness = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Fitness"));
		this.rb_Fitness.CanFocus = true;
		this.rb_Fitness.Name = "rb_Fitness";
		this.rb_Fitness.DrawIndicator = true;
		this.rb_Fitness.UseUnderline = true;
		this.rb_Fitness.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox5.Add (this.rb_Fitness);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.rb_Fitness]));
		w40.Position = 1;
		// Container child hbox5.Gtk.Box+BoxChild
		this.rb_Rank = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Rang"));
		this.rb_Rank.WidthRequest = 0;
		this.rb_Rank.CanFocus = true;
		this.rb_Rank.Name = "rb_Rank";
		this.rb_Rank.DrawIndicator = true;
		this.rb_Rank.UseUnderline = true;
		this.rb_Rank.Group = this.rb_Fitness.Group;
		this.hbox5.Add (this.rb_Rank);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.rb_Rank]));
		w41.Position = 2;
		this.vbox6.Add (this.hbox5);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox5]));
		w42.Position = 1;
		w42.Expand = false;
		w42.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label10 = new global::Gtk.Label ();
		this.label10.WidthRequest = 107;
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Elternselektion");
		this.hbox6.Add (this.label10);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label10]));
		w43.Position = 0;
		w43.Expand = false;
		w43.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.cbo_SelType = global::Gtk.ComboBox.NewText ();
		this.cbo_SelType.AppendText (global::Mono.Unix.Catalog.GetString ("Roulette"));
		this.cbo_SelType.AppendText (global::Mono.Unix.Catalog.GetString ("q-Fache Turnierselektion"));
		this.cbo_SelType.AppendText (global::Mono.Unix.Catalog.GetString ("q-Stufige Zweifache Turnierselektion"));
		this.cbo_SelType.WidthRequest = 122;
		this.cbo_SelType.Name = "cbo_SelType";
		this.cbo_SelType.Active = 0;
		this.hbox6.Add (this.cbo_SelType);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.cbo_SelType]));
		w44.Position = 1;
		w44.Expand = false;
		w44.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.txt_TournamentMemberCount = new global::Gtk.SpinButton (0, 100, 1);
		this.txt_TournamentMemberCount.WidthRequest = 88;
		this.txt_TournamentMemberCount.Sensitive = false;
		this.txt_TournamentMemberCount.CanFocus = true;
		this.txt_TournamentMemberCount.Name = "txt_TournamentMemberCount";
		this.txt_TournamentMemberCount.Adjustment.PageIncrement = 10;
		this.txt_TournamentMemberCount.ClimbRate = 1;
		this.txt_TournamentMemberCount.Numeric = true;
		this.hbox6.Add (this.txt_TournamentMemberCount);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txt_TournamentMemberCount]));
		w45.Position = 2;
		w45.Expand = false;
		w45.Fill = false;
		this.vbox6.Add (this.hbox6);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox6]));
		w46.Position = 2;
		w46.Expand = false;
		w46.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.pnl_recombEncrypt = new global::Gtk.HBox ();
		this.pnl_recombEncrypt.Name = "pnl_recombEncrypt";
		this.pnl_recombEncrypt.Spacing = 6;
		// Container child pnl_recombEncrypt.Gtk.Box+BoxChild
		this.lbl_Recombination = new global::Gtk.Label ();
		this.lbl_Recombination.WidthRequest = 107;
		this.lbl_Recombination.Name = "lbl_Recombination";
		this.lbl_Recombination.LabelProp = global::Mono.Unix.Catalog.GetString ("Rekombination");
		this.pnl_recombEncrypt.Add (this.lbl_Recombination);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.pnl_recombEncrypt [this.lbl_Recombination]));
		w47.Position = 0;
		w47.Expand = false;
		w47.Fill = false;
		// Container child pnl_recombEncrypt.Gtk.Box+BoxChild
		this.cbo_recombBinary = global::Gtk.ComboBox.NewText ();
		this.cbo_recombBinary.AppendText (global::Mono.Unix.Catalog.GetString ("1-Punkt"));
		this.cbo_recombBinary.AppendText (global::Mono.Unix.Catalog.GetString ("2-Punkt"));
		this.cbo_recombBinary.WidthRequest = 92;
		this.cbo_recombBinary.Name = "cbo_recombBinary";
		this.cbo_recombBinary.Active = 0;
		this.pnl_recombEncrypt.Add (this.cbo_recombBinary);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.pnl_recombEncrypt [this.cbo_recombBinary]));
		w48.Position = 1;
		w48.Expand = false;
		w48.Fill = false;
		// Container child pnl_recombEncrypt.Gtk.Box+BoxChild
		this.cbo_recombReal = global::Gtk.ComboBox.NewText ();
		this.cbo_recombReal.AppendText (global::Mono.Unix.Catalog.GetString ("Intermediär"));
		this.cbo_recombReal.AppendText (global::Mono.Unix.Catalog.GetString ("Arithmetisch"));
		this.cbo_recombReal.WidthRequest = 121;
		this.cbo_recombReal.Name = "cbo_recombReal";
		this.cbo_recombReal.Active = 0;
		this.pnl_recombEncrypt.Add (this.cbo_recombReal);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.pnl_recombEncrypt [this.cbo_recombReal]));
		w49.Position = 2;
		w49.Expand = false;
		w49.Fill = false;
		this.vbox6.Add (this.pnl_recombEncrypt);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.pnl_recombEncrypt]));
		w50.Position = 3;
		w50.Expand = false;
		w50.Fill = false;
		this.GtkAlignment2.Add (this.vbox6);
		this.frame_Evolution.Add (this.GtkAlignment2);
		this.GtkLabel9 = new global::Gtk.Label ();
		this.GtkLabel9.Name = "GtkLabel9";
		this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Evolution</b>");
		this.GtkLabel9.UseMarkup = true;
		this.frame_Evolution.LabelWidget = this.GtkLabel9;
		this.vbox_TabEigenschaften.Add (this.frame_Evolution);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox_TabEigenschaften [this.frame_Evolution]));
		w53.Position = 2;
		w53.Expand = false;
		w53.Fill = false;
		this.mainTabWidget.Add (this.vbox_TabEigenschaften);
		global::Gtk.Notebook.NotebookChild w54 = ((global::Gtk.Notebook.NotebookChild)(this.mainTabWidget [this.vbox_TabEigenschaften]));
		w54.Position = 1;
		// Notebook tab
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Eigenschaften</b>");
		this.label11.UseMarkup = true;
		this.mainTabWidget.SetTabLabel (this.vbox_TabEigenschaften, this.label11);
		this.label11.ShowAll ();
		this.vbox_right.Add (this.mainTabWidget);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox_right [this.mainTabWidget]));
		w55.Position = 0;
		// Container child vbox_right.Gtk.Box+BoxChild
		this.btn_Start = new global::Gtk.Button ();
		this.btn_Start.CanFocus = true;
		this.btn_Start.Name = "btn_Start";
		this.btn_Start.UseUnderline = true;
		this.btn_Start.Label = global::Mono.Unix.Catalog.GetString ("Evolutioniere!");
		this.vbox_right.Add (this.btn_Start);
		global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox_right [this.btn_Start]));
		w56.Position = 1;
		w56.Expand = false;
		w56.Fill = false;
		// Container child vbox_right.Gtk.Box+BoxChild
		this.btn_Start10 = new global::Gtk.Button ();
		this.btn_Start10.CanFocus = true;
		this.btn_Start10.Name = "btn_Start10";
		this.btn_Start10.UseUnderline = true;
		this.btn_Start10.Label = global::Mono.Unix.Catalog.GetString ("Evolutioniere x 10!");
		this.vbox_right.Add (this.btn_Start10);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox_right [this.btn_Start10]));
		w57.Position = 2;
		w57.Expand = false;
		w57.Fill = false;
		this.pnl_mainWidget.Add (this.vbox_right);
		global::Gtk.Paned.PanedChild w58 = ((global::Gtk.Paned.PanedChild)(this.pnl_mainWidget [this.vbox_right]));
		w58.Shrink = false;
		this.vbox_main.Add (this.pnl_mainWidget);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox_main [this.pnl_mainWidget]));
		w59.Position = 0;
		// Container child vbox_main.Gtk.Box+BoxChild
		this.statusbar = new global::Gtk.Statusbar ();
		this.statusbar.Name = "statusbar";
		this.statusbar.Spacing = 6;
		// Container child statusbar.Gtk.Box+BoxChild
		this.progressbar = new global::Gtk.ProgressBar ();
		this.progressbar.Name = "progressbar";
		this.statusbar.Add (this.progressbar);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.statusbar [this.progressbar]));
		w60.Position = 1;
		this.vbox_main.Add (this.statusbar);
		global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox_main [this.statusbar]));
		w61.Position = 1;
		w61.Expand = false;
		w61.Fill = false;
		this.Add (this.vbox_main);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 744;
		this.DefaultHeight = 547;
		this.pnl_MutationType.Hide ();
		this.cbo_recombBinary.Hide ();
		this.cbo_recombReal.Hide ();
		this.pnl_mainWidget.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.cbo_Encryption.Changed += new global::System.EventHandler (this.OnCboEncryptionChanged);
		this.cbo_SelType.Changed += new global::System.EventHandler (this.OnCboSelTypeChanged);
		this.btn_Start.Clicked += new global::System.EventHandler (this.OnBtnStartClicked);
		this.btn_Start10.Clicked += new global::System.EventHandler (this.OnBtnStart10Clicked);
	}
}
