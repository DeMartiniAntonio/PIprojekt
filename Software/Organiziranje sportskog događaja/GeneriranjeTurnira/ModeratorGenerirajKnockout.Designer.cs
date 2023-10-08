namespace Organiziranje_sportskog_događaja
{
    partial class ModeratorGenerirajKnockout
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
            this.popisUtakmicaDTG = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.finaleDTG = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.slijedecaTekmaBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.goloviT2TXB = new System.Windows.Forms.TextBox();
            this.goloviT1TXB = new System.Windows.Forms.TextBox();
            this.tim2DTG = new System.Windows.Forms.DataGridView();
            this.tim1DTG = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.krajBTN = new System.Windows.Forms.Button();
            this.pokreniUtakmicuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisUtakmicaDTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finaleDTG)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tim2DTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tim1DTG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisUtakmicaDTG
            // 
            this.popisUtakmicaDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisUtakmicaDTG.Location = new System.Drawing.Point(44, 76);
            this.popisUtakmicaDTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.popisUtakmicaDTG.Name = "popisUtakmicaDTG";
            this.popisUtakmicaDTG.RowHeadersWidth = 51;
            this.popisUtakmicaDTG.Size = new System.Drawing.Size(761, 617);
            this.popisUtakmicaDTG.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Finale";
            // 
            // finaleDTG
            // 
            this.finaleDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finaleDTG.Location = new System.Drawing.Point(27, 332);
            this.finaleDTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finaleDTG.Name = "finaleDTG";
            this.finaleDTG.RowHeadersWidth = 51;
            this.finaleDTG.Size = new System.Drawing.Size(740, 71);
            this.finaleDTG.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pokreniUtakmicuBtn);
            this.groupBox1.Controls.Add(this.slijedecaTekmaBTN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.goloviT2TXB);
            this.groupBox1.Controls.Add(this.goloviT1TXB);
            this.groupBox1.Controls.Add(this.tim2DTG);
            this.groupBox1.Controls.Add(this.tim1DTG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(755, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutna utakmica";
            // 
            // slijedecaTekmaBTN
            // 
            this.slijedecaTekmaBTN.Enabled = false;
            this.slijedecaTekmaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slijedecaTekmaBTN.Location = new System.Drawing.Point(407, 161);
            this.slijedecaTekmaBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slijedecaTekmaBTN.Name = "slijedecaTekmaBTN";
            this.slijedecaTekmaBTN.Size = new System.Drawing.Size(184, 50);
            this.slijedecaTekmaBTN.TabIndex = 7;
            this.slijedecaTekmaBTN.Text = "Slijedeća utakmica";
            this.slijedecaTekmaBTN.UseVisualStyleBackColor = true;
            this.slijedecaTekmaBTN.Click += new System.EventHandler(this.slijedecaTekmaBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // goloviT2TXB
            // 
            this.goloviT2TXB.Location = new System.Drawing.Point(407, 103);
            this.goloviT2TXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goloviT2TXB.Name = "goloviT2TXB";
            this.goloviT2TXB.Size = new System.Drawing.Size(39, 26);
            this.goloviT2TXB.TabIndex = 10;
            // 
            // goloviT1TXB
            // 
            this.goloviT1TXB.Location = new System.Drawing.Point(331, 103);
            this.goloviT1TXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goloviT1TXB.Name = "goloviT1TXB";
            this.goloviT1TXB.Size = new System.Drawing.Size(39, 26);
            this.goloviT1TXB.TabIndex = 9;
            // 
            // tim2DTG
            // 
            this.tim2DTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tim2DTG.Location = new System.Drawing.Point(455, 85);
            this.tim2DTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tim2DTG.Name = "tim2DTG";
            this.tim2DTG.RowHeadersWidth = 51;
            this.tim2DTG.Size = new System.Drawing.Size(292, 69);
            this.tim2DTG.TabIndex = 8;
            // 
            // tim1DTG
            // 
            this.tim1DTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tim1DTG.Location = new System.Drawing.Point(29, 85);
            this.tim1DTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tim1DTG.Name = "tim1DTG";
            this.tim1DTG.RowHeadersWidth = 51;
            this.tim1DTG.Size = new System.Drawing.Size(288, 69);
            this.tim1DTG.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.krajBTN);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.finaleDTG);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(853, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(783, 644);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // krajBTN
            // 
            this.krajBTN.Enabled = false;
            this.krajBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krajBTN.Location = new System.Drawing.Point(317, 447);
            this.krajBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.krajBTN.Name = "krajBTN";
            this.krajBTN.Size = new System.Drawing.Size(184, 50);
            this.krajBTN.TabIndex = 12;
            this.krajBTN.Text = "Kraj turnira";
            this.krajBTN.UseVisualStyleBackColor = true;
            this.krajBTN.Click += new System.EventHandler(this.krajBTN_Click);
            // 
            // pokreniUtakmicuBtn
            // 
            this.pokreniUtakmicuBtn.Enabled = false;
            this.pokreniUtakmicuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokreniUtakmicuBtn.Location = new System.Drawing.Point(186, 161);
            this.pokreniUtakmicuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pokreniUtakmicuBtn.Name = "pokreniUtakmicuBtn";
            this.pokreniUtakmicuBtn.Size = new System.Drawing.Size(184, 50);
            this.pokreniUtakmicuBtn.TabIndex = 12;
            this.pokreniUtakmicuBtn.Text = "Pokreni utakmicu";
            this.pokreniUtakmicuBtn.UseVisualStyleBackColor = true;
            this.pokreniUtakmicuBtn.Click += new System.EventHandler(this.pokreniUtakmicuBtn_Click);
            // 
            // ModeratorGenerirajKnockout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 807);
            this.Controls.Add(this.popisUtakmicaDTG);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModeratorGenerirajKnockout";
            this.Text = "moderator_generirajKnock";
            this.Load += new System.EventHandler(this.ModeratorGenerirajKnockout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisUtakmicaDTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finaleDTG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tim2DTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tim1DTG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView popisUtakmicaDTG;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView finaleDTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goloviT2TXB;
        private System.Windows.Forms.TextBox goloviT1TXB;
        private System.Windows.Forms.DataGridView tim2DTG;
        private System.Windows.Forms.DataGridView tim1DTG;
        internal System.Windows.Forms.Button slijedecaTekmaBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button krajBTN;
        internal System.Windows.Forms.Button pokreniUtakmicuBtn;
    }
}