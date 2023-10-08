namespace Organiziranje_sportskog_događaja
{
    partial class DodajModeratoraDogadajuForma
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
            this.moderatoriDogadajaDgv = new System.Windows.Forms.DataGridView();
            this.moderatoriCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajModeratoraBtn = new System.Windows.Forms.Button();
            this.nazadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moderatoriDogadajaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // moderatoriDogadajaDgv
            // 
            this.moderatoriDogadajaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moderatoriDogadajaDgv.Location = new System.Drawing.Point(12, 12);
            this.moderatoriDogadajaDgv.Name = "moderatoriDogadajaDgv";
            this.moderatoriDogadajaDgv.RowHeadersWidth = 51;
            this.moderatoriDogadajaDgv.RowTemplate.Height = 24;
            this.moderatoriDogadajaDgv.Size = new System.Drawing.Size(661, 253);
            this.moderatoriDogadajaDgv.TabIndex = 0;
            // 
            // moderatoriCmb
            // 
            this.moderatoriCmb.FormattingEnabled = true;
            this.moderatoriCmb.Location = new System.Drawing.Point(185, 283);
            this.moderatoriCmb.Name = "moderatoriCmb";
            this.moderatoriCmb.Size = new System.Drawing.Size(263, 24);
            this.moderatoriCmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisnicko ime moderatora";
            // 
            // dodajModeratoraBtn
            // 
            this.dodajModeratoraBtn.Location = new System.Drawing.Point(502, 277);
            this.dodajModeratoraBtn.Name = "dodajModeratoraBtn";
            this.dodajModeratoraBtn.Size = new System.Drawing.Size(171, 35);
            this.dodajModeratoraBtn.TabIndex = 3;
            this.dodajModeratoraBtn.Text = "Dodaj moderatora";
            this.dodajModeratoraBtn.UseVisualStyleBackColor = true;
            this.dodajModeratoraBtn.Click += new System.EventHandler(this.dodajModeratoraBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(15, 359);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(75, 36);
            this.nazadBtn.TabIndex = 4;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            // 
            // DodajModeratoraDogadajuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 415);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.dodajModeratoraBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moderatoriCmb);
            this.Controls.Add(this.moderatoriDogadajaDgv);
            this.Name = "DodajModeratoraDogadajuForma";
            this.Text = "DodajModeratoraDogadajuForma";
            this.Load += new System.EventHandler(this.DodajModeratoraDogadajuForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moderatoriDogadajaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView moderatoriDogadajaDgv;
        private System.Windows.Forms.ComboBox moderatoriCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajModeratoraBtn;
        private System.Windows.Forms.Button nazadBtn;
    }
}