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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btGoToSeh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btGoToBio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Willkommen Zu Teste Dich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "<--------------------------------------------------------------------------------" +
    "------------->";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btGoToSeh
            // 
            this.btGoToSeh.Location = new System.Drawing.Point(124, 111);
            this.btGoToSeh.Name = "btGoToSeh";
            this.btGoToSeh.Size = new System.Drawing.Size(119, 58);
            this.btGoToSeh.TabIndex = 2;
            this.btGoToSeh.Text = "Gehe zu Sehtest";
            this.btGoToSeh.UseVisualStyleBackColor = true;
            this.btGoToSeh.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btGoToBio
            // 
            this.btGoToBio.Location = new System.Drawing.Point(581, 107);
            this.btGoToBio.Name = "btGoToBio";
            this.btGoToBio.Size = new System.Drawing.Size(128, 67);
            this.btGoToBio.TabIndex = 4;
            this.btGoToBio.Text = "Gehe zum Biorythmus";
            this.btGoToBio.UseVisualStyleBackColor = true;
            this.btGoToBio.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGoToBio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btGoToSeh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Startseite";
            this.Text = "Startseite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGoToSeh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btGoToBio;
    }
}