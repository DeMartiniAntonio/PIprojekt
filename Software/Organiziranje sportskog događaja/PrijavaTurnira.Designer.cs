namespace Organiziranje_sportskog_događaja
{
    partial class PrijavaTurnira
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
            this.uiSpremiTurnir = new System.Windows.Forms.Button();
            this.uiMinBroj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiMaxBroj = new System.Windows.Forms.TextBox();
            this.uiKotizacija = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSpremiTurnir
            // 
            this.uiSpremiTurnir.Location = new System.Drawing.Point(660, 451);
            this.uiSpremiTurnir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiSpremiTurnir.Name = "uiSpremiTurnir";
            this.uiSpremiTurnir.Size = new System.Drawing.Size(125, 48);
            this.uiSpremiTurnir.TabIndex = 32;
            this.uiSpremiTurnir.Text = "Spremi";
            this.uiSpremiTurnir.UseVisualStyleBackColor = true;
            this.uiSpremiTurnir.Click += new System.EventHandler(this.uiSpremiTurnir_Click);
            // 
            // uiMinBroj
            // 
            this.uiMinBroj.Location = new System.Drawing.Point(224, 439);
            this.uiMinBroj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiMinBroj.Name = "uiMinBroj";
            this.uiMinBroj.Size = new System.Drawing.Size(146, 26);
            this.uiMinBroj.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Maksimalan broj igrača";
            // 
            // uiMaxBroj
            // 
            this.uiMaxBroj.Location = new System.Drawing.Point(639, 394);
            this.uiMaxBroj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiMaxBroj.Name = "uiMaxBroj";
            this.uiMaxBroj.Size = new System.Drawing.Size(146, 26);
            this.uiMaxBroj.TabIndex = 29;
            // 
            // uiKotizacija
            // 
            this.uiKotizacija.Location = new System.Drawing.Point(639, 349);
            this.uiKotizacija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiKotizacija.Name = "uiKotizacija";
            this.uiKotizacija.Size = new System.Drawing.Size(146, 26);
            this.uiKotizacija.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Iznos kotizacije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Minimalan broj igrača";
            // 
            // uiKategorije
            // 
            this.uiKategorije.FormattingEnabled = true;
            this.uiKategorije.Location = new System.Drawing.Point(224, 394);
            this.uiKategorije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiKategorije.Name = "uiKategorije";
            this.uiKategorije.Size = new System.Drawing.Size(146, 28);
            this.uiKategorije.TabIndex = 25;
            this.uiKategorije.SelectedIndexChanged += new System.EventHandler(this.uiKategorije_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kategorija sporta";
            // 
            // uiNaziv
            // 
            this.uiNaziv.Location = new System.Drawing.Point(224, 349);
            this.uiNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiNaziv.Name = "uiNaziv";
            this.uiNaziv.Size = new System.Drawing.Size(146, 26);
            this.uiNaziv.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Naziv turnira";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(753, 260);
            this.dataGridView1.TabIndex = 33;
            // 
            // PrijavaTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uiSpremiTurnir);
            this.Controls.Add(this.uiMinBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiMaxBroj);
            this.Controls.Add(this.uiKotizacija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiKategorije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiNaziv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrijavaTurnira";
            this.Text = "PrijavaTurnira";
            this.Load += new System.EventHandler(this.PrijavaTurnira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiSpremiTurnir;
        private System.Windows.Forms.TextBox uiMinBroj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiMaxBroj;
        private System.Windows.Forms.TextBox uiKotizacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uiKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}