
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;
	private global::Gtk.HPaned hpaned4;
	private global::Gtk.VBox vbox5;
	private global::Gtk.Frame frame4;
	private global::Gtk.Alignment GtkAlignment3;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView txt_Output;
	private global::Gtk.Label GtkLabel7;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Notebook notebook1;
	private global::Gtk.VBox vbox7;
	private global::Gtk.Frame frame5;
	private global::Gtk.Alignment GtkAlignment4;
	private global::Gtk.VBox vbox8;
	private global::Gtk.ComboBox cbo_Problem;
	private global::Gtk.Label GtkLabel;
	private global::Gtk.Frame frame6;
	private global::Gtk.Alignment GtkAlignment5;
	private global::Gtk.VBox vbox9;
	private global::Gtk.ComboBox cbo_Encryption;
	private global::Gtk.Label GtkLabel11;
	private global::Gtk.Label label1;
	private global::Gtk.VBox vbox1;
	private global::Gtk.Frame frame1;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HPaned hpaned1;
	private global::Gtk.Label label2;
	private global::Gtk.SpinButton txt_countIndividuals;
	private global::Gtk.HPaned hpaned2;
	private global::Gtk.Label label4;
	private global::Gtk.SpinButton txt_maxGeneration;
	private global::Gtk.HPaned hpaned5;
	private global::Gtk.Label label5;
	private global::Gtk.SpinButton txt_countChilds;
	private global::Gtk.HPaned hpaned6;
	private global::Gtk.Label label6;
	private global::Gtk.SpinButton txt_recombProb;
	private global::Gtk.Label GtkLabel1;
	private global::Gtk.Frame frame2;
	private global::Gtk.Alignment GtkAlignment1;
	private global::Gtk.VBox vbox4;
	private global::Gtk.HPaned hpaned12;
	private global::Gtk.Label label7;
	private global::Gtk.SpinButton txt_countGenes;
	private global::Gtk.Label GtkLabel2;
	private global::Gtk.Frame frame3;
	private global::Gtk.Alignment GtkAlignment2;
	private global::Gtk.VBox vbox6;
	private global::Gtk.HPaned hpaned3;
	private global::Gtk.Label label8;
	private global::Gtk.HBox hbox2;
	private global::Gtk.RadioButton rb_Change;
	private global::Gtk.RadioButton rb_Invert;
	private global::Gtk.HPaned hpaned7;
	private global::Gtk.Label label9;
	private global::Gtk.HBox hbox3;
	private global::Gtk.RadioButton rb_Fitness;
	private global::Gtk.RadioButton rb_Rank;
	private global::Gtk.HPaned hpaned8;
	private global::Gtk.Label label10;
	private global::Gtk.HPaned hpaned9;
	private global::Gtk.ComboBox cbo_SelType;
	private global::Gtk.SpinButton txt_TournamentMemberCount;
	private global::Gtk.Label GtkLabel9;
	private global::Gtk.Label label11;
	private global::Gtk.Button btn_Start;
	private global::Gtk.Button btn_Start10;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hpaned4 = new global::Gtk.HPaned ();
		this.hpaned4.CanFocus = true;
		this.hpaned4.Name = "hpaned4";
		this.hpaned4.Position = 365;
		// Container child hpaned4.Gtk.Paned+PanedChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
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
		this.GtkScrolledWindow.Add (this.txt_Output);
		this.GtkAlignment3.Add (this.GtkScrolledWindow);
		this.frame4.Add (this.GtkAlignment3);
		this.GtkLabel7 = new global::Gtk.Label ();
		this.GtkLabel7.Name = "GtkLabel7";
		this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Ausgabe</b>");
		this.GtkLabel7.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel7;
		this.vbox5.Add (this.frame4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame4]));
		w4.Position = 1;
		this.hpaned4.Add (this.vbox5);
		global::Gtk.Paned.PanedChild w5 = ((global::Gtk.Paned.PanedChild)(this.hpaned4 [this.vbox5]));
		w5.Resize = false;
		// Container child hpaned4.Gtk.Paned+PanedChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook ();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 1;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.frame5 = new global::Gtk.Frame ();
		this.frame5.Name = "frame5";
		this.frame5.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame5.BorderWidth = ((uint)(1));
		// Container child frame5.Gtk.Container+ContainerChild
		this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment4.Name = "GtkAlignment4";
		this.GtkAlignment4.LeftPadding = ((uint)(12));
		// Container child GtkAlignment4.Gtk.Container+ContainerChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.cbo_Problem = global::Gtk.ComboBox.NewText ();
		this.cbo_Problem.AppendText (global::Mono.Unix.Catalog.GetString ("Traveling Salesman"));
		this.cbo_Problem.Name = "cbo_Problem";
		this.cbo_Problem.Active = 0;
		this.vbox8.Add (this.cbo_Problem);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.cbo_Problem]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		this.GtkAlignment4.Add (this.vbox8);
		this.frame5.Add (this.GtkAlignment4);
		this.GtkLabel = new global::Gtk.Label ();
		this.GtkLabel.Name = "GtkLabel";
		this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Art</b>");
		this.GtkLabel.UseMarkup = true;
		this.frame5.LabelWidget = this.GtkLabel;
		this.vbox7.Add (this.frame5);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.frame5]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.frame6 = new global::Gtk.Frame ();
		this.frame6.Name = "frame6";
		this.frame6.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame6.BorderWidth = ((uint)(1));
		// Container child frame6.Gtk.Container+ContainerChild
		this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment5.Name = "GtkAlignment5";
		this.GtkAlignment5.LeftPadding = ((uint)(12));
		// Container child GtkAlignment5.Gtk.Container+ContainerChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.cbo_Encryption = global::Gtk.ComboBox.NewText ();
		this.cbo_Encryption.AppendText (global::Mono.Unix.Catalog.GetString ("ohne"));
		this.cbo_Encryption.AppendText (global::Mono.Unix.Catalog.GetString ("Binär"));
		this.cbo_Encryption.AppendText (global::Mono.Unix.Catalog.GetString ("Reell"));
		this.cbo_Encryption.Name = "cbo_Encryption";
		this.cbo_Encryption.Active = 0;
		this.vbox9.Add (this.cbo_Encryption);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.cbo_Encryption]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		this.GtkAlignment5.Add (this.vbox9);
		this.frame6.Add (this.GtkAlignment5);
		this.GtkLabel11 = new global::Gtk.Label ();
		this.GtkLabel11.Name = "GtkLabel11";
		this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Kodierung</b>");
		this.GtkLabel11.UseMarkup = true;
		this.frame6.LabelWidget = this.GtkLabel11;
		this.vbox7.Add (this.frame6);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.frame6]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.notebook1.Add (this.vbox7);
		// Notebook tab
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Problem</b>");
		this.label1.UseMarkup = true;
		this.notebook1.SetTabLabel (this.vbox7, this.label1);
		this.label1.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame1.BorderWidth = ((uint)(1));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 143;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Individuen");
		this.hpaned1.Add (this.label2);
		global::Gtk.Paned.PanedChild w15 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.label2]));
		w15.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.txt_countIndividuals = new global::Gtk.SpinButton (0, 1000, 1);
		this.txt_countIndividuals.CanFocus = true;
		this.txt_countIndividuals.Name = "txt_countIndividuals";
		this.txt_countIndividuals.Adjustment.PageIncrement = 10;
		this.txt_countIndividuals.ClimbRate = 1;
		this.txt_countIndividuals.Numeric = true;
		this.txt_countIndividuals.Value = 10;
		this.hpaned1.Add (this.txt_countIndividuals);
		this.vbox3.Add (this.hpaned1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned1]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hpaned2 = new global::Gtk.HPaned ();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 142;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Generationen");
		this.hpaned2.Add (this.label4);
		global::Gtk.Paned.PanedChild w18 = ((global::Gtk.Paned.PanedChild)(this.hpaned2 [this.label4]));
		w18.Resize = false;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.txt_maxGeneration = new global::Gtk.SpinButton (0, 10000, 1);
		this.txt_maxGeneration.CanFocus = true;
		this.txt_maxGeneration.Name = "txt_maxGeneration";
		this.txt_maxGeneration.Adjustment.PageIncrement = 10;
		this.txt_maxGeneration.ClimbRate = 1;
		this.txt_maxGeneration.Numeric = true;
		this.txt_maxGeneration.Value = 10;
		this.hpaned2.Add (this.txt_maxGeneration);
		this.vbox3.Add (this.hpaned2);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned2]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hpaned5 = new global::Gtk.HPaned ();
		this.hpaned5.CanFocus = true;
		this.hpaned5.Name = "hpaned5";
		this.hpaned5.Position = 142;
		// Container child hpaned5.Gtk.Paned+PanedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Nachkommen");
		this.hpaned5.Add (this.label5);
		global::Gtk.Paned.PanedChild w21 = ((global::Gtk.Paned.PanedChild)(this.hpaned5 [this.label5]));
		w21.Resize = false;
		// Container child hpaned5.Gtk.Paned+PanedChild
		this.txt_countChilds = new global::Gtk.SpinButton (0, 1000, 1);
		this.txt_countChilds.CanFocus = true;
		this.txt_countChilds.Name = "txt_countChilds";
		this.txt_countChilds.Adjustment.PageIncrement = 10;
		this.txt_countChilds.ClimbRate = 1;
		this.txt_countChilds.Numeric = true;
		this.txt_countChilds.Value = 10;
		this.hpaned5.Add (this.txt_countChilds);
		this.vbox3.Add (this.hpaned5);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned5]));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hpaned6 = new global::Gtk.HPaned ();
		this.hpaned6.CanFocus = true;
		this.hpaned6.Name = "hpaned6";
		this.hpaned6.Position = 141;
		// Container child hpaned6.Gtk.Paned+PanedChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Rekomb. Wahrsch.");
		this.hpaned6.Add (this.label6);
		global::Gtk.Paned.PanedChild w24 = ((global::Gtk.Paned.PanedChild)(this.hpaned6 [this.label6]));
		w24.Resize = false;
		// Container child hpaned6.Gtk.Paned+PanedChild
		this.txt_recombProb = new global::Gtk.SpinButton (0, 1, 0.1);
		this.txt_recombProb.CanFocus = true;
		this.txt_recombProb.Name = "txt_recombProb";
		this.txt_recombProb.Adjustment.PageIncrement = 0.1;
		this.txt_recombProb.ClimbRate = 1;
		this.txt_recombProb.Digits = ((uint)(2));
		this.txt_recombProb.Numeric = true;
		this.txt_recombProb.Value = 0.3;
		this.hpaned6.Add (this.txt_recombProb);
		this.vbox3.Add (this.hpaned6);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned6]));
		w26.Position = 3;
		w26.Expand = false;
		w26.Fill = false;
		this.GtkAlignment.Add (this.vbox3);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label ();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Population</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel1;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame2.BorderWidth = ((uint)(1));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hpaned12 = new global::Gtk.HPaned ();
		this.hpaned12.CanFocus = true;
		this.hpaned12.Name = "hpaned12";
		this.hpaned12.Position = 143;
		// Container child hpaned12.Gtk.Paned+PanedChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Anzahl Gene");
		this.hpaned12.Add (this.label7);
		global::Gtk.Paned.PanedChild w30 = ((global::Gtk.Paned.PanedChild)(this.hpaned12 [this.label7]));
		w30.Resize = false;
		// Container child hpaned12.Gtk.Paned+PanedChild
		this.txt_countGenes = new global::Gtk.SpinButton (0, 100, 1);
		this.txt_countGenes.CanFocus = true;
		this.txt_countGenes.Name = "txt_countGenes";
		this.txt_countGenes.Adjustment.PageIncrement = 10;
		this.txt_countGenes.ClimbRate = 1;
		this.txt_countGenes.Numeric = true;
		this.txt_countGenes.Value = 6;
		this.hpaned12.Add (this.txt_countGenes);
		this.vbox4.Add (this.hpaned12);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hpaned12]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		this.GtkAlignment1.Add (this.vbox4);
		this.frame2.Add (this.GtkAlignment1);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Genom</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel2;
		this.vbox1.Add (this.frame2);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame2]));
		w35.Position = 1;
		w35.Expand = false;
		w35.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame ();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame3.BorderWidth = ((uint)(1));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hpaned3 = new global::Gtk.HPaned ();
		this.hpaned3.CanFocus = true;
		this.hpaned3.Name = "hpaned3";
		this.hpaned3.Position = 114;
		// Container child hpaned3.Gtk.Paned+PanedChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Mutation");
		this.hpaned3.Add (this.label8);
		global::Gtk.Paned.PanedChild w36 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.label8]));
		w36.Resize = false;
		// Container child hpaned3.Gtk.Paned+PanedChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.rb_Change = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Tauschen"));
		this.rb_Change.CanFocus = true;
		this.rb_Change.Name = "rb_Change";
		this.rb_Change.DrawIndicator = true;
		this.rb_Change.UseUnderline = true;
		this.rb_Change.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox2.Add (this.rb_Change);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.rb_Change]));
		w37.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.rb_Invert = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Invertieren"));
		this.rb_Invert.CanFocus = true;
		this.rb_Invert.Name = "rb_Invert";
		this.rb_Invert.DrawIndicator = true;
		this.rb_Invert.UseUnderline = true;
		this.rb_Invert.Group = this.rb_Change.Group;
		this.hbox2.Add (this.rb_Invert);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.rb_Invert]));
		w38.Position = 1;
		this.hpaned3.Add (this.hbox2);
		this.vbox6.Add (this.hpaned3);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hpaned3]));
		w40.Position = 0;
		w40.Expand = false;
		w40.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hpaned7 = new global::Gtk.HPaned ();
		this.hpaned7.CanFocus = true;
		this.hpaned7.Name = "hpaned7";
		this.hpaned7.Position = 115;
		// Container child hpaned7.Gtk.Paned+PanedChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Zufallsselektion");
		this.hpaned7.Add (this.label9);
		global::Gtk.Paned.PanedChild w41 = ((global::Gtk.Paned.PanedChild)(this.hpaned7 [this.label9]));
		w41.Resize = false;
		// Container child hpaned7.Gtk.Paned+PanedChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.rb_Fitness = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Fitness"));
		this.rb_Fitness.CanFocus = true;
		this.rb_Fitness.Name = "rb_Fitness";
		this.rb_Fitness.DrawIndicator = true;
		this.rb_Fitness.UseUnderline = true;
		this.rb_Fitness.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox3.Add (this.rb_Fitness);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.rb_Fitness]));
		w42.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.rb_Rank = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Rang"));
		this.rb_Rank.CanFocus = true;
		this.rb_Rank.Name = "rb_Rank";
		this.rb_Rank.DrawIndicator = true;
		this.rb_Rank.UseUnderline = true;
		this.rb_Rank.Group = this.rb_Fitness.Group;
		this.hbox3.Add (this.rb_Rank);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.rb_Rank]));
		w43.Position = 1;
		this.hpaned7.Add (this.hbox3);
		this.vbox6.Add (this.hpaned7);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hpaned7]));
		w45.Position = 1;
		w45.Expand = false;
		w45.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hpaned8 = new global::Gtk.HPaned ();
		this.hpaned8.CanFocus = true;
		this.hpaned8.Name = "hpaned8";
		this.hpaned8.Position = 102;
		// Container child hpaned8.Gtk.Paned+PanedChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Elternselektion");
		this.hpaned8.Add (this.label10);
		global::Gtk.Paned.PanedChild w46 = ((global::Gtk.Paned.PanedChild)(this.hpaned8 [this.label10]));
		w46.Resize = false;
		// Container child hpaned8.Gtk.Paned+PanedChild
		this.hpaned9 = new global::Gtk.HPaned ();
		this.hpaned9.CanFocus = true;
		this.hpaned9.Name = "hpaned9";
		this.hpaned9.Position = 192;
		// Container child hpaned9.Gtk.Paned+PanedChild
		this.cbo_SelType = global::Gtk.ComboBox.NewText ();
		this.cbo_SelType.AppendText (global::Mono.Unix.Catalog.GetString ("Roulette"));
		this.cbo_SelType.AppendText (global::Mono.Unix.Catalog.GetString ("q-Fache Turnierselektion"));
		this.cbo_SelType.AppendText (global::Mono.Unix.Catalog.GetString ("q-Stufige Zweifache Turnierselektion"));
		this.cbo_SelType.Name = "cbo_SelType";
		this.cbo_SelType.Active = 0;
		this.hpaned9.Add (this.cbo_SelType);
		global::Gtk.Paned.PanedChild w47 = ((global::Gtk.Paned.PanedChild)(this.hpaned9 [this.cbo_SelType]));
		w47.Resize = false;
		// Container child hpaned9.Gtk.Paned+PanedChild
		this.txt_TournamentMemberCount = new global::Gtk.SpinButton (0, 100, 1);
		this.txt_TournamentMemberCount.Sensitive = false;
		this.txt_TournamentMemberCount.CanFocus = true;
		this.txt_TournamentMemberCount.Name = "txt_TournamentMemberCount";
		this.txt_TournamentMemberCount.Adjustment.PageIncrement = 10;
		this.txt_TournamentMemberCount.ClimbRate = 1;
		this.txt_TournamentMemberCount.Numeric = true;
		this.hpaned9.Add (this.txt_TournamentMemberCount);
		this.hpaned8.Add (this.hpaned9);
		this.vbox6.Add (this.hpaned8);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hpaned8]));
		w50.Position = 2;
		w50.Expand = false;
		w50.Fill = false;
		this.GtkAlignment2.Add (this.vbox6);
		this.frame3.Add (this.GtkAlignment2);
		this.GtkLabel9 = new global::Gtk.Label ();
		this.GtkLabel9.Name = "GtkLabel9";
		this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Evolution</b>");
		this.GtkLabel9.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel9;
		this.vbox1.Add (this.frame3);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame3]));
		w53.Position = 2;
		w53.Expand = false;
		w53.Fill = false;
		this.notebook1.Add (this.vbox1);
		global::Gtk.Notebook.NotebookChild w54 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox1]));
		w54.Position = 1;
		// Notebook tab
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Eigenschaften</b>");
		this.label11.UseMarkup = true;
		this.notebook1.SetTabLabel (this.vbox1, this.label11);
		this.label11.ShowAll ();
		this.vbox2.Add (this.notebook1);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebook1]));
		w55.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btn_Start = new global::Gtk.Button ();
		this.btn_Start.CanFocus = true;
		this.btn_Start.Name = "btn_Start";
		this.btn_Start.UseUnderline = true;
		this.btn_Start.Label = global::Mono.Unix.Catalog.GetString ("Evolutioniere!");
		this.vbox2.Add (this.btn_Start);
		global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btn_Start]));
		w56.Position = 1;
		w56.Expand = false;
		w56.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btn_Start10 = new global::Gtk.Button ();
		this.btn_Start10.CanFocus = true;
		this.btn_Start10.Name = "btn_Start10";
		this.btn_Start10.UseUnderline = true;
		this.btn_Start10.Label = global::Mono.Unix.Catalog.GetString ("Evolutioniere x 10!");
		this.vbox2.Add (this.btn_Start10);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btn_Start10]));
		w57.Position = 2;
		w57.Expand = false;
		w57.Fill = false;
		this.hpaned4.Add (this.vbox2);
		this.hbox1.Add (this.hpaned4);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hpaned4]));
		w59.Position = 0;
		this.Add (this.hbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 811;
		this.DefaultHeight = 548;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.cbo_SelType.Changed += new global::System.EventHandler (this.OnCboSelTypeChanged);
		this.btn_Start.Clicked += new global::System.EventHandler (this.OnBtnStartClicked);
		this.btn_Start10.Clicked += new global::System.EventHandler (this.OnBtnStart10Clicked);
	}
}
