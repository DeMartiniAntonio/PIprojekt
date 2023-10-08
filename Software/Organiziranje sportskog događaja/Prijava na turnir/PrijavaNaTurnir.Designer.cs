namespace Organiziranje_sportskog_događaja
{
    partial class PrijavaNaTurnir
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
            this.uiProvjeriStatus = new System.Windows.Forms.Button();
            this.uiPrijaviTim = new System.Windows.Forms.Button();
            this.uiPrijaviSeSamostalno = new System.Windows.Forms.Button();
            this.uiPrikazTurniraZavrsenihPrijava = new System.Windows.Forms.DataGridView();
            this.uiPrikazTurniraZaPrijavu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazTurniraZavrsenihPrijava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazTurniraZaPrijavu)).BeginInit();
            this.SuspendLayout();
            // 
            // uiProvjeriStatus
            // 
            this.uiProvjeriStatus.Location = new System.Drawing.Point(255, 391);
            this.uiProvjeriStatus.Name = "uiProvjeriStatus";
            this.uiProvjeriStatus.Size = new System.Drawing.Size(102, 51);
            this.uiProvjeriStatus.TabIndex = 14;
            this.uiProvjeriStatus.Text = "Provjeri svoj status";
            this.uiProvjeriStatus.UseVisualStyleBackColor = true;
            this.uiProvjeriStatus.Click += new System.EventHandler(this.uiProvjeriStatus_Click);
            // 
            // uiPrijaviTim
            // 
            this.uiPrijaviTim.Location = new System.Drawing.Point(255, 176);
            this.uiPrijaviTim.Name = "uiPrijaviTim";
            this.uiPrijaviTim.Size = new System.Drawing.Size(102, 51);
            this.uiPrijaviTim.TabIndex = 13;
            this.uiPrijaviTim.Text = "Prijavi tim";
            this.uiPrijaviTim.UseVisualStyleBackColor = true;
            this.uiPrijaviTim.Click += new System.EventHandler(this.uiPrijaviTim_Click);
            // 
            // uiPrijaviSeSamostalno
            // 
            this.uiPrijaviSeSamostalno.Location = new System.Drawing.Point(367, 176);
            this.uiPrijaviSeSamostalno.Name = "uiPrijaviSeSamostalno";
            this.uiPrijaviSeSamostalno.Size = new System.Drawing.Size(102, 51);
            this.uiPrijaviSeSamostalno.TabIndex = 12;
            this.uiPrijaviSeSamostalno.Text = "Prijavi se samostalno";
            this.uiPrijaviSeSamostalno.UseVisualStyleBackColor = true;
            this.uiPrijaviSeSamostalno.Click += new System.EventHandler(this.uiPrijaviSeSamostalno_Click);
            // 
            // uiPrikazTurniraZavrsenihPrijava
            // 
            this.uiPrikazTurniraZavrsenihPrijava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazTurniraZavrsenihPrijava.Location = new System.Drawing.Point(15, 249);
            this.uiPrikazTurniraZavrsenihPrijava.Name = "uiPrikazTurniraZavrsenihPrijava";
            this.uiPrikazTurniraZavrsenihPrijava.RowHeadersWidth = 51;
            this.uiPrikazTurniraZavrsenihPrijava.RowTemplate.Height = 24;
            this.uiPrikazTurniraZavrsenihPrijava.Size = new System.Drawing.Size(457, 136);
            this.uiPrikazTurniraZavrsenihPrijava.TabIndex = 11;
            // 
            // uiPrikazTurniraZaPrijavu
            // 
            this.uiPrikazTurniraZaPrijavu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazTurniraZaPrijavu.Location = new System.Drawing.Point(12, 34);
            this.uiPrikazTurniraZaPrijavu.Name = "uiPrikazTurniraZaPrijavu";
            this.uiPrikazTurniraZaPrijavu.RowHeadersWidth = 51;
            this.uiPrikazTurniraZaPrijavu.RowTemplate.Height = 24;
            this.uiPrikazTurniraZaPrijavu.Size = new System.Drawing.Size(457, 136);
            this.uiPrikazTurniraZaPrijavu.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rezultati generiranja timova: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Turniri na koje se možete prijaviti: ";
            // 
            // uiNatrag
            // 
            this.uiNatrag.Location = new System.Drawing.Point(367, 391);
            this.uiNatrag.Name = "uiNatrag";
            this.uiNatrag.Size = new System.Drawing.Size(102, 51);
            this.uiNatrag.TabIndex = 15;
            this.uiNatrag.Text = "Natrag";
            this.uiNatrag.UseVisualStyleBackColor = true;
            this.uiNatrag.Click += new System.EventHandler(this.uiNatrag_Click);
            // 
            // PrijavaNaTurnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.uiNatrag);
            this.Controls.Add(this.uiProvjeriStatus);
            this.Controls.Add(this.uiPrijaviTim);
            this.Controls.Add(this.uiPrijaviSeSamostalno);
            this.Controls.Add(this.uiPrikazTurniraZavrsenihPrijava);
            this.Controls.Add(this.uiPrikazTurniraZaPrijavu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrijavaNaTurnir";
            this.Text = "PrijavaNaTurnir";
            this.Load += new System.EventHandler(this.PrijavaNaTurnir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazTurniraZavrsenihPrijava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazTurniraZaPrijavu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiProvjeriStatus;
        private System.Windows.Forms.Button uiPrijaviTim;
        private System.Windows.Forms.Button uiPrijaviSeSamostalno;
        private System.Windows.Forms.DataGridView uiPrikazTurniraZavrsenihPrijava;
        private System.Windows.Forms.DataGridView uiPrikazTurniraZaPrijavu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiNatrag;
    }
}