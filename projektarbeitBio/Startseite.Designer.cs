namespace projektarbeitBio
{
    partial class Startseite
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
            this.lbUeberschrift = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btGoToSeh = new System.Windows.Forms.Button();
            this.btGoToBio = new System.Windows.Forms.Button();
            this.btEND = new System.Windows.Forms.Button();
            this.lbTimer2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUeberschrift
            // 
            this.lbUeberschrift.AutoSize = true;
            this.lbUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUeberschrift.Location = new System.Drawing.Point(152, 38);
            this.lbUeberschrift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUeberschrift.Name = "lbUeberschrift";
            this.lbUeberschrift.Size = new System.Drawing.Size(746, 69);
            this.lbUeberschrift.TabIndex = 0;
            this.lbUeberschrift.Text = "Willkommen Zu Teste Dich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "<--------------------------------------------------------------------------------" +
    "----------------------->";
            // 
            // btGoToSeh
            // 
            this.btGoToSeh.Location = new System.Drawing.Point(165, 137);
            this.btGoToSeh.Margin = new System.Windows.Forms.Padding(4);
            this.btGoToSeh.Name = "btGoToSeh";
            this.btGoToSeh.Size = new System.Drawing.Size(159, 71);
            this.btGoToSeh.TabIndex = 2;
            this.btGoToSeh.Text = "Gehe zu Sehtest";
            this.btGoToSeh.UseVisualStyleBackColor = true;
            this.btGoToSeh.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btGoToBio
            // 
            this.btGoToBio.Location = new System.Drawing.Point(775, 132);
            this.btGoToBio.Margin = new System.Windows.Forms.Padding(4);
            this.btGoToBio.Name = "btGoToBio";
            this.btGoToBio.Size = new System.Drawing.Size(171, 82);
            this.btGoToBio.TabIndex = 4;
            this.btGoToBio.Text = "Gehe zum Biorythmus";
            this.btGoToBio.UseVisualStyleBackColor = true;
            this.btGoToBio.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btEND
            // 
            this.btEND.Location = new System.Drawing.Point(854, 427);
            this.btEND.Name = "btEND";
            this.btEND.Size = new System.Drawing.Size(171, 82);
            this.btEND.TabIndex = 5;
            this.btEND.Text = "END";
            this.btEND.UseVisualStyleBackColor = true;
            this.btEND.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbTimer2
            // 
            this.lbTimer2.AutoSize = true;
            this.lbTimer2.Location = new System.Drawing.Point(980, 9);
            this.lbTimer2.Name = "lbTimer2";
            this.lbTimer2.Size = new System.Drawing.Size(24, 17);
            this.lbTimer2.TabIndex = 6;
            this.lbTimer2.Text = "__";
            this.lbTimer2.Click += new System.EventHandler(this.lbTimer2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.comboBox1.Location = new System.Drawing.Point(184, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Erscheinungsbild";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Registrieren";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Login";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbTimer2);
            this.Controls.Add(this.btEND);
            this.Controls.Add(this.btGoToBio);
            this.Controls.Add(this.btGoToSeh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUeberschrift);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Startseite";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.Startseite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUeberschrift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGoToSeh;
        private System.Windows.Forms.Button btGoToBio;
        private System.Windows.Forms.Button btEND;
        private System.Windows.Forms.Label lbTimer2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}