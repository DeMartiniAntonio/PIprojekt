namespace Organiziranje_sportskog_događaja
{
    partial class ModeratorDodijeljeniDogađaji
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
            this.dogadajiDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.turniriDgv = new System.Windows.Forms.DataGridView();
            this.pokreniTurnirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajiDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turniriDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dogadajiDgv
            // 
            this.dogadajiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogadajiDgv.Location = new System.Drawing.Point(6, 33);
            this.dogadajiDgv.Name = "dogadajiDgv";
            this.dogadajiDgv.RowHeadersWidth = 51;
            this.dogadajiDgv.RowTemplate.Height = 24;
            this.dogadajiDgv.Size = new System.Drawing.Size(666, 200);
            this.dogadajiDgv.TabIndex = 1;
            this.dogadajiDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dogadajiDgv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.turniriDgv);
            this.groupBox1.Controls.Add(this.pokreniTurnirBtn);
            this.groupBox1.Controls.Add(this.dogadajiDgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 453);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled događaja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Popis turnira:";
            // 
            // turniriDgv
            // 
            this.turniriDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turniriDgv.Location = new System.Drawing.Point(6, 263);
            this.turniriDgv.Name = "turniriDgv";
            this.turniriDgv.RowHeadersWidth = 51;
            this.turniriDgv.RowTemplate.Height = 24;
            this.turniriDgv.Size = new System.Drawing.Size(666, 107);
            this.turniriDgv.TabIndex = 11;
            // 
            // pokreniTurnirBtn
            // 
            this.pokreniTurnirBtn.Location = new System.Drawing.Point(551, 385);
            this.pokreniTurnirBtn.Name = "pokreniTurnirBtn";
            this.pokreniTurnirBtn.Size = new System.Drawing.Size(121, 52);
            this.pokreniTurnirBtn.TabIndex = 10;
            this.pokreniTurnirBtn.Text = "Pokreni turnir";
            this.pokreniTurnirBtn.UseVisualStyleBackColor = true;
            this.pokreniTurnirBtn.Click += new System.EventHandler(this.pokreniTurnirBtn_Click);
            // 
            // ModeratorDodijeljeniDogađaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 485);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModeratorDodijeljeniDogađaji";
            this.Text = "Dodijeljeni događaji";
            this.Load += new System.EventHandler(this.ModeratorDodijeljeniDogađaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogadajiDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turniriDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dogadajiDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView turniriDgv;
        private System.Windows.Forms.Button pokreniTurnirBtn;
    }
}

