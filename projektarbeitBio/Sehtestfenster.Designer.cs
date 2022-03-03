namespace projektarbeitBio
{
    partial class Sehtestfenster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sehtestfenster));
            this.lbSehtest = new System.Windows.Forms.Label();
            this.imagelistFarben = new System.Windows.Forms.ImageList(this.components);
            this.btZeigeBild = new System.Windows.Forms.Button();
            this.btErgebnis = new System.Windows.Forms.Button();
            this.lbUebersSeh = new System.Windows.Forms.Label();
            this.tbeingabe = new System.Windows.Forms.TextBox();
            this.lbDE = new System.Windows.Forms.Label();
            this.btZZSt = new System.Windows.Forms.Button();
            this.lbTimer3 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cbErscheinungsbild = new System.Windows.Forms.ComboBox();
            this.lbEr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSehtest
            // 
            this.lbSehtest.ImageIndex = 0;
            this.lbSehtest.ImageList = this.imagelistFarben;
            this.lbSehtest.Location = new System.Drawing.Point(343, 97);
            this.lbSehtest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSehtest.Name = "lbSehtest";
            this.lbSehtest.Size = new System.Drawing.Size(347, 287);
            this.lbSehtest.TabIndex = 0;
            this.lbSehtest.Text = ".";
            // 
            // imagelistFarben
            // 
            this.imagelistFarben.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistFarben.ImageStream")));
            this.imagelistFarben.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistFarben.Images.SetKeyName(0, "1BG Sehtest_Farben_675 x520px_sRGB.jpg");
            this.imagelistFarben.Images.SetKeyName(1, "2index.jpg");
            this.imagelistFarben.Images.SetKeyName(2, "3ishihara_farbtafel_11.png");
            // 
            // btZeigeBild
            // 
            this.btZeigeBild.Location = new System.Drawing.Point(25, 97);
            this.btZeigeBild.Margin = new System.Windows.Forms.Padding(4);
            this.btZeigeBild.Name = "btZeigeBild";
            this.btZeigeBild.Size = new System.Drawing.Size(285, 123);
            this.btZeigeBild.TabIndex = 1;
            this.btZeigeBild.Text = "Zeige Bild";
            this.btZeigeBild.UseVisualStyleBackColor = true;
            this.btZeigeBild.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btErgebnis
            // 
            this.btErgebnis.Location = new System.Drawing.Point(25, 260);
            this.btErgebnis.Margin = new System.Windows.Forms.Padding(4);
            this.btErgebnis.Name = "btErgebnis";
            this.btErgebnis.Size = new System.Drawing.Size(285, 124);
            this.btErgebnis.TabIndex = 2;
            this.btErgebnis.Text = "Ergebnis";
            this.btErgebnis.UseVisualStyleBackColor = true;
            this.btErgebnis.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbUebersSeh
            // 
            this.lbUebersSeh.AutoSize = true;
            this.lbUebersSeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUebersSeh.Location = new System.Drawing.Point(110, 39);
            this.lbUebersSeh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUebersSeh.Name = "lbUebersSeh";
            this.lbUebersSeh.Size = new System.Drawing.Size(549, 54);
            this.lbUebersSeh.TabIndex = 4;
            this.lbUebersSeh.Text = "Willkommen zum Sehtest";
            // 
            // tbeingabe
            // 
            this.tbeingabe.Location = new System.Drawing.Point(177, 228);
            this.tbeingabe.Margin = new System.Windows.Forms.Padding(4);
            this.tbeingabe.Name = "tbeingabe";
            this.tbeingabe.Size = new System.Drawing.Size(132, 22);
            this.tbeingabe.TabIndex = 5;
            // 
            // lbDE
            // 
            this.lbDE.AutoSize = true;
            this.lbDE.Location = new System.Drawing.Point(21, 231);
            this.lbDE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDE.Name = "lbDE";
            this.lbDE.Size = new System.Drawing.Size(97, 17);
            this.lbDE.TabIndex = 6;
            this.lbDE.Text = "Dein Ergebnis";
            // 
            // btZZSt
            // 
            this.btZZSt.Location = new System.Drawing.Point(625, 486);
            this.btZZSt.Margin = new System.Windows.Forms.Padding(4);
            this.btZZSt.Name = "btZZSt";
            this.btZZSt.Size = new System.Drawing.Size(143, 53);
            this.btZZSt.TabIndex = 7;
            this.btZZSt.Text = "Zurück zur Startseite";
            this.btZZSt.UseVisualStyleBackColor = true;
            this.btZZSt.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lbTimer3
            // 
            this.lbTimer3.AutoSize = true;
            this.lbTimer3.Location = new System.Drawing.Point(697, 9);
            this.lbTimer3.Name = "lbTimer3";
            this.lbTimer3.Size = new System.Drawing.Size(24, 17);
            this.lbTimer3.TabIndex = 8;
            this.lbTimer3.Text = "__";
            this.lbTimer3.Click += new System.EventHandler(this.lbTimer3_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cbErscheinungsbild
            // 
            this.cbErscheinungsbild.FormattingEnabled = true;
            this.cbErscheinungsbild.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.cbErscheinungsbild.Location = new System.Drawing.Point(85, 452);
            this.cbErscheinungsbild.Name = "cbErscheinungsbild";
            this.cbErscheinungsbild.Size = new System.Drawing.Size(121, 24);
            this.cbErscheinungsbild.TabIndex = 9;
            this.cbErscheinungsbild.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbEr
            // 
            this.lbEr.AutoSize = true;
            this.lbEr.Location = new System.Drawing.Point(82, 432);
            this.lbEr.Name = "lbEr";
            this.lbEr.Size = new System.Drawing.Size(116, 17);
            this.lbEr.TabIndex = 10;
            this.lbEr.Text = "Erscheinungsbild";
            // 
            // Sehtestfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 554);
            this.Controls.Add(this.lbEr);
            this.Controls.Add(this.cbErscheinungsbild);
            this.Controls.Add(this.lbTimer3);
            this.Controls.Add(this.btZZSt);
            this.Controls.Add(this.lbDE);
            this.Controls.Add(this.tbeingabe);
            this.Controls.Add(this.lbUebersSeh);
            this.Controls.Add(this.btErgebnis);
            this.Controls.Add(this.btZeigeBild);
            this.Controls.Add(this.lbSehtest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sehtestfenster";
            this.Text = "Sehtestfenster";
            this.Load += new System.EventHandler(this.Sehtestfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSehtest;
        private System.Windows.Forms.Button btZeigeBild;
        private System.Windows.Forms.Button btErgebnis;
        private System.Windows.Forms.Label lbUebersSeh;
        private System.Windows.Forms.TextBox tbeingabe;
        private System.Windows.Forms.Label lbDE;
        private System.Windows.Forms.ImageList imagelistFarben;
        private System.Windows.Forms.Button btZZSt;
        private System.Windows.Forms.Label lbTimer3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox cbErscheinungsbild;
        private System.Windows.Forms.Label lbEr;
    }
}