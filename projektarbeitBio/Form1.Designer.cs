namespace projektarbeitBio
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbPrognose_14Tage = new System.Windows.Forms.RichTextBox();
            this.plPrognose_60Tage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbMonat = new System.Windows.Forms.TextBox();
            this.tbJahr = new System.Windows.Forms.TextBox();
            this.lbGeburtsdatum = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbJ = new System.Windows.Forms.Label();
            this.lbTD = new System.Windows.Forms.Label();
            this.lbTagesdatum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbKoerperlich = new System.Windows.Forms.Label();
            this.lbGeistig = new System.Windows.Forms.Label();
            this.lbPsychisch = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTageSeitGeburt = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btVerarbeitung = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbUebTDK = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbU = new System.Windows.Forms.Label();
            this.lbUhrzeit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbAusgabeGDay = new System.Windows.Forms.Label();
            this.lbAusagbeBDay = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPrognose_14Tage
            // 
            this.rtbPrognose_14Tage.Location = new System.Drawing.Point(611, 153);
            this.rtbPrognose_14Tage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbPrognose_14Tage.Name = "rtbPrognose_14Tage";
            this.rtbPrognose_14Tage.Size = new System.Drawing.Size(317, 164);
            this.rtbPrognose_14Tage.TabIndex = 0;
            this.rtbPrognose_14Tage.Text = "";
            // 
            // plPrognose_60Tage
            // 
            this.plPrognose_60Tage.BackColor = System.Drawing.Color.White;
            this.plPrognose_60Tage.Location = new System.Drawing.Point(611, 386);
            this.plPrognose_60Tage.Margin = new System.Windows.Forms.Padding(4);
            this.plPrognose_60Tage.Name = "plPrognose_60Tage";
            this.plPrognose_60Tage.Size = new System.Drawing.Size(319, 167);
            this.plPrognose_60Tage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tag     körperlich     geistig     psychisch  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prognose 14 Tage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prognose 60 Tage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(608, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "köerperlich                                              ";
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(249, 164);
            this.tbTag.Margin = new System.Windows.Forms.Padding(4);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(132, 22);
            this.tbTag.TabIndex = 6;
            // 
            // tbMonat
            // 
            this.tbMonat.Location = new System.Drawing.Point(249, 196);
            this.tbMonat.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonat.Name = "tbMonat";
            this.tbMonat.Size = new System.Drawing.Size(132, 22);
            this.tbMonat.TabIndex = 7;
            // 
            // tbJahr
            // 
            this.tbJahr.Location = new System.Drawing.Point(249, 228);
            this.tbJahr.Margin = new System.Windows.Forms.Padding(4);
            this.tbJahr.Name = "tbJahr";
            this.tbJahr.Size = new System.Drawing.Size(132, 22);
            this.tbJahr.TabIndex = 8;
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtsdatum.Location = new System.Drawing.Point(152, 140);
            this.lbGeburtsdatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(115, 20);
            this.lbGeburtsdatum.TabIndex = 9;
            this.lbGeburtsdatum.Text = "Geburtsdatum";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbT.Location = new System.Drawing.Point(197, 165);
            this.lbT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(37, 20);
            this.lbT.TabIndex = 10;
            this.lbT.Text = "Tag";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.Location = new System.Drawing.Point(181, 197);
            this.lbM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(55, 20);
            this.lbM.TabIndex = 11;
            this.lbM.Text = "Monat";
            // 
            // lbJ
            // 
            this.lbJ.AutoSize = true;
            this.lbJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJ.Location = new System.Drawing.Point(196, 229);
            this.lbJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJ.Name = "lbJ";
            this.lbJ.Size = new System.Drawing.Size(42, 20);
            this.lbJ.TabIndex = 12;
            this.lbJ.Text = "Jahr";
            // 
            // lbTD
            // 
            this.lbTD.AutoSize = true;
            this.lbTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTD.Location = new System.Drawing.Point(152, 273);
            this.lbTD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTD.Name = "lbTD";
            this.lbTD.Size = new System.Drawing.Size(101, 20);
            this.lbTD.TabIndex = 13;
            this.lbTD.Text = "Tagesdatum";
            // 
            // lbTagesdatum
            // 
            this.lbTagesdatum.AutoSize = true;
            this.lbTagesdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTagesdatum.Location = new System.Drawing.Point(273, 273);
            this.lbTagesdatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTagesdatum.Name = "lbTagesdatum";
            this.lbTagesdatum.Size = new System.Drawing.Size(27, 20);
            this.lbTagesdatum.TabIndex = 14;
            this.lbTagesdatum.Text = "__";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tageskondition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "körperlich";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(227, 500);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "geistig";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(200, 522);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "psychisch";
            // 
            // lbKoerperlich
            // 
            this.lbKoerperlich.AutoSize = true;
            this.lbKoerperlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKoerperlich.Location = new System.Drawing.Point(299, 480);
            this.lbKoerperlich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKoerperlich.Name = "lbKoerperlich";
            this.lbKoerperlich.Size = new System.Drawing.Size(27, 20);
            this.lbKoerperlich.TabIndex = 19;
            this.lbKoerperlich.Text = "__";
            // 
            // lbGeistig
            // 
            this.lbGeistig.AutoSize = true;
            this.lbGeistig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeistig.Location = new System.Drawing.Point(299, 500);
            this.lbGeistig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeistig.Name = "lbGeistig";
            this.lbGeistig.Size = new System.Drawing.Size(27, 20);
            this.lbGeistig.TabIndex = 20;
            this.lbGeistig.Text = "__";
            // 
            // lbPsychisch
            // 
            this.lbPsychisch.AutoSize = true;
            this.lbPsychisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPsychisch.Location = new System.Drawing.Point(299, 522);
            this.lbPsychisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPsychisch.Name = "lbPsychisch";
            this.lbPsychisch.Size = new System.Drawing.Size(27, 20);
            this.lbPsychisch.TabIndex = 21;
            this.lbPsychisch.Text = "__";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(152, 326);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Du hast vor ";
            // 
            // lbTageSeitGeburt
            // 
            this.lbTageSeitGeburt.AutoSize = true;
            this.lbTageSeitGeburt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTageSeitGeburt.Location = new System.Drawing.Point(251, 326);
            this.lbTageSeitGeburt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTageSeitGeburt.Name = "lbTageSeitGeburt";
            this.lbTageSeitGeburt.Size = new System.Drawing.Size(27, 20);
            this.lbTageSeitGeburt.TabIndex = 23;
            this.lbTageSeitGeburt.Text = "__";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(304, 326);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Tagen";
            // 
            // btVerarbeitung
            // 
            this.btVerarbeitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerarbeitung.Location = new System.Drawing.Point(148, 386);
            this.btVerarbeitung.Margin = new System.Windows.Forms.Padding(4);
            this.btVerarbeitung.Name = "btVerarbeitung";
            this.btVerarbeitung.Size = new System.Drawing.Size(220, 48);
            this.btVerarbeitung.TabIndex = 26;
            this.btVerarbeitung.Text = "Verarbeitung";
            this.btVerarbeitung.UseVisualStyleBackColor = true;
            this.btVerarbeitung.Click += new System.EventHandler(this.BtVerarbeitung_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(152, 346);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "das Licht der Welt erblickt.";
            // 
            // lbUebTDK
            // 
            this.lbUebTDK.AutoSize = true;
            this.lbUebTDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUebTDK.Location = new System.Drawing.Point(293, 33);
            this.lbUebTDK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUebTDK.Name = "lbUebTDK";
            this.lbUebTDK.Size = new System.Drawing.Size(464, 52);
            this.lbUebTDK.TabIndex = 28;
            this.lbUebTDK.Text = "Teste deine Kondition";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(743, 366);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "geistig";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(839, 366);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "psychisch";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1280, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 31;
            this.button1.Text = "Zurück zur Startseite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbU
            // 
            this.lbU.AutoSize = true;
            this.lbU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbU.Location = new System.Drawing.Point(196, 300);
            this.lbU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbU.Name = "lbU";
            this.lbU.Size = new System.Drawing.Size(63, 20);
            this.lbU.TabIndex = 32;
            this.lbU.Text = "Uhrzeit";
            // 
            // lbUhrzeit
            // 
            this.lbUhrzeit.AutoSize = true;
            this.lbUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeit.Location = new System.Drawing.Point(273, 300);
            this.lbUhrzeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUhrzeit.Name = "lbUhrzeit";
            this.lbUhrzeit.Size = new System.Drawing.Size(27, 20);
            this.lbUhrzeit.TabIndex = 33;
            this.lbUhrzeit.Text = "__";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(1321, 9);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(27, 20);
            this.lbTimer.TabIndex = 34;
            this.lbTimer.Text = "__";
            this.lbTimer.Click += new System.EventHandler(this.LbTimer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.comboBox1.Location = new System.Drawing.Point(1039, 139);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lbAusgabeGDay
            // 
            this.lbAusgabeGDay.AutoSize = true;
            this.lbAusgabeGDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAusgabeGDay.Location = new System.Drawing.Point(1035, 228);
            this.lbAusgabeGDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAusgabeGDay.Name = "lbAusgabeGDay";
            this.lbAusgabeGDay.Size = new System.Drawing.Size(27, 20);
            this.lbAusgabeGDay.TabIndex = 37;
            this.lbAusgabeGDay.Text = "__";
            // 
            // lbAusagbeBDay
            // 
            this.lbAusagbeBDay.AutoSize = true;
            this.lbAusagbeBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAusagbeBDay.Location = new System.Drawing.Point(1035, 248);
            this.lbAusagbeBDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAusagbeBDay.Name = "lbAusagbeBDay";
            this.lbAusagbeBDay.Size = new System.Drawing.Size(27, 20);
            this.lbAusagbeBDay.TabIndex = 38;
            this.lbAusagbeBDay.Text = "__";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1039, 116);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 20);
            this.label21.TabIndex = 39;
            this.label21.Text = "Erscheinungsbild";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(777, 103);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 28);
            this.button2.TabIndex = 40;
            this.button2.Text = "nächtsen 14 Tage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1063, 196);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 20);
            this.label22.TabIndex = 41;
            this.label22.Text = "7 Tage Vorschau";
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projektarbeitBio.Properties.Resources._200w;
            this.pictureBox1.Location = new System.Drawing.Point(1039, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbAusagbeBDay);
            this.Controls.Add(this.lbAusgabeGDay);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbUhrzeit);
            this.Controls.Add(this.lbU);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbUebTDK);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btVerarbeitung);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbTageSeitGeburt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbPsychisch);
            this.Controls.Add(this.lbGeistig);
            this.Controls.Add(this.lbKoerperlich);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTagesdatum);
            this.Controls.Add(this.lbTD);
            this.Controls.Add(this.lbJ);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.lbGeburtsdatum);
            this.Controls.Add(this.tbJahr);
            this.Controls.Add(this.tbMonat);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plPrognose_60Tage);
            this.Controls.Add(this.rtbPrognose_14Tage);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPrognose_14Tage;
        private System.Windows.Forms.Panel plPrognose_60Tage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbMonat;
        private System.Windows.Forms.TextBox tbJahr;
        private System.Windows.Forms.Label lbGeburtsdatum;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbJ;
        private System.Windows.Forms.Label lbTD;
        private System.Windows.Forms.Label lbTagesdatum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbKoerperlich;
        private System.Windows.Forms.Label lbGeistig;
        private System.Windows.Forms.Label lbPsychisch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTageSeitGeburt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btVerarbeitung;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbUebTDK;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbU;
        private System.Windows.Forms.Label lbUhrzeit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbAusgabeGDay;
        private System.Windows.Forms.Label lbAusagbeBDay;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

