
namespace projektarbeitBio
{
    partial class Beenden
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
            this.btJa = new System.Windows.Forms.Button();
            this.btNein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wirklich beenden?";
            // 
            // btJa
            // 
            this.btJa.Location = new System.Drawing.Point(51, 135);
            this.btJa.Name = "btJa";
            this.btJa.Size = new System.Drawing.Size(150, 70);
            this.btJa.TabIndex = 1;
            this.btJa.Text = "JA";
            this.btJa.UseVisualStyleBackColor = true;
            this.btJa.Click += new System.EventHandler(this.btJa_Click);
            // 
            // btNein
            // 
            this.btNein.Location = new System.Drawing.Point(292, 135);
            this.btNein.Name = "btNein";
            this.btNein.Size = new System.Drawing.Size(150, 70);
            this.btNein.TabIndex = 2;
            this.btNein.Text = "NEIN";
            this.btNein.UseVisualStyleBackColor = true;
            this.btNein.Click += new System.EventHandler(this.btNein_Click);
            // 
            // Beenden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 251);
            this.Controls.Add(this.btNein);
            this.Controls.Add(this.btJa);
            this.Controls.Add(this.label1);
            this.Name = "Beenden";
            this.Text = "Beenden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btJa;
        private System.Windows.Forms.Button btNein;
    }
}