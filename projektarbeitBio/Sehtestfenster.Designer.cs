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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbeingabe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSehtest
            // 
            this.lbSehtest.ImageIndex = 0;
            this.lbSehtest.ImageList = this.imagelistFarben;
            this.lbSehtest.Location = new System.Drawing.Point(257, 79);
            this.lbSehtest.Name = "lbSehtest";
            this.lbSehtest.Size = new System.Drawing.Size(260, 233);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zeige Bild";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 101);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ergebnis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Willkommen zum Sehtest";
            // 
            // tbeingabe
            // 
            this.tbeingabe.Location = new System.Drawing.Point(133, 185);
            this.tbeingabe.Name = "tbeingabe";
            this.tbeingabe.Size = new System.Drawing.Size(100, 20);
            this.tbeingabe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dein Ergebnis";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Zurück zur Startseite";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Sehtestfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbeingabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSehtest);
            this.Name = "Sehtestfenster";
            this.Text = "Sehtestfenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSehtest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbeingabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imagelistFarben;
        private System.Windows.Forms.Button button3;
    }
}