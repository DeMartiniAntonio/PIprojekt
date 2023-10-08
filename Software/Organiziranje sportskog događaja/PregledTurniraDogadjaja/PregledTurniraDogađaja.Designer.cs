namespace Organiziranje_sportskog_događaja.PregledTurniraDogadjaja
{
    partial class PregledTurniraDogađaja
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
            this.Sport = new System.Windows.Forms.GroupBox();
            this.nogometCB = new System.Windows.Forms.CheckBox();
            this.kosarkaCB = new System.Windows.Forms.CheckBox();
            this.rukometCB = new System.Windows.Forms.CheckBox();
            this.pregledDTG = new System.Windows.Forms.DataGridView();
            this.pretraziBTN = new System.Windows.Forms.Button();
            this.natragBTN = new System.Windows.Forms.Button();
            this.pretrazivanjeTXB = new System.Windows.Forms.TextBox();
            this.samostalnaPrijava = new System.Windows.Forms.Button();
            this.prijaviTim = new System.Windows.Forms.Button();
            this.Sport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled turnira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pretrazi po imenu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Sport
            // 
            this.Sport.Controls.Add(this.nogometCB);
            this.Sport.Controls.Add(this.kosarkaCB);
            this.Sport.Controls.Add(this.rukometCB);
            this.Sport.Location = new System.Drawing.Point(40, 116);
            this.Sport.Name = "Sport";
            this.Sport.Size = new System.Drawing.Size(200, 100);
            this.Sport.TabIndex = 3;
            this.Sport.TabStop = false;
            this.Sport.Text = "groupBox2";
            // 
            // nogometCB
            // 
            this.nogometCB.AutoSize = true;
            this.nogometCB.Location = new System.Drawing.Point(6, 19);
            this.nogometCB.Name = "nogometCB";
            this.nogometCB.Size = new System.Drawing.Size(69, 17);
            this.nogometCB.TabIndex = 2;
            this.nogometCB.Text = "Nogomet";
            this.nogometCB.UseVisualStyleBackColor = true;
            // 
            // kosarkaCB
            // 
            this.kosarkaCB.AutoSize = true;
            this.kosarkaCB.Location = new System.Drawing.Point(6, 42);
            this.kosarkaCB.Name = "kosarkaCB";
            this.kosarkaCB.Size = new System.Drawing.Size(65, 17);
            this.kosarkaCB.TabIndex = 3;
            this.kosarkaCB.Text = "Košarka";
            this.kosarkaCB.UseVisualStyleBackColor = true;
            // 
            // rukometCB
            // 
            this.rukometCB.AutoSize = true;
            this.rukometCB.Location = new System.Drawing.Point(6, 65);
            this.rukometCB.Name = "rukometCB";
            this.rukometCB.Size = new System.Drawing.Size(69, 17);
            this.rukometCB.TabIndex = 4;
            this.rukometCB.Text = "Rukomet";
            this.rukometCB.UseVisualStyleBackColor = true;
            // 
            // pregledDTG
            // 
            this.pregledDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledDTG.Location = new System.Drawing.Point(256, 116);
            this.pregledDTG.Name = "pregledDTG";
            this.pregledDTG.Size = new System.Drawing.Size(647, 205);
            this.pregledDTG.TabIndex = 4;
            this.pregledDTG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pregledDTG_MouseClick);
            // 
            // pretraziBTN
            // 
            this.pretraziBTN.Location = new System.Drawing.Point(645, 85);
            this.pretraziBTN.Name = "pretraziBTN";
            this.pretraziBTN.Size = new System.Drawing.Size(75, 23);
            this.pretraziBTN.TabIndex = 5;
            this.pretraziBTN.Text = "Pretraži";
            this.pretraziBTN.UseVisualStyleBackColor = true;
            this.pretraziBTN.Click += new System.EventHandler(this.pretraziBTN_Click);
            // 
            // natragBTN
            // 
            this.natragBTN.Location = new System.Drawing.Point(828, 327);
            this.natragBTN.Name = "natragBTN";
            this.natragBTN.Size = new System.Drawing.Size(75, 23);
            this.natragBTN.TabIndex = 7;
            this.natragBTN.Text = "Natrag";
            this.natragBTN.UseVisualStyleBackColor = true;
            this.natragBTN.Click += new System.EventHandler(this.natragBTN_Click);
            // 
            // pretrazivanjeTXB
            // 
            this.pretrazivanjeTXB.Location = new System.Drawing.Point(370, 88);
            this.pretrazivanjeTXB.Name = "pretrazivanjeTXB";
            this.pretrazivanjeTXB.Size = new System.Drawing.Size(242, 20);
            this.pretrazivanjeTXB.TabIndex = 8;
            // 
            // samostalnaPrijava
            // 
            this.samostalnaPrijava.Location = new System.Drawing.Point(494, 327);
            this.samostalnaPrijava.Name = "samostalnaPrijava";
            this.samostalnaPrijava.Size = new System.Drawing.Size(166, 23);
            this.samostalnaPrijava.TabIndex = 9;
            this.samostalnaPrijava.Text = "Prijavi se samostalno";
            this.samostalnaPrijava.UseVisualStyleBackColor = true;
            this.samostalnaPrijava.Click += new System.EventHandler(this.samostalnaPrijava_Click);
            // 
            // prijaviTim
            // 
            this.prijaviTim.Location = new System.Drawing.Point(666, 327);
            this.prijaviTim.Name = "prijaviTim";
            this.prijaviTim.Size = new System.Drawing.Size(75, 23);
            this.prijaviTim.TabIndex = 10;
            this.prijaviTim.Text = "Prijavi tim";
            this.prijaviTim.UseVisualStyleBackColor = true;
            this.prijaviTim.Click += new System.EventHandler(this.prijaviTim_Click);
            // 
            // PregledTurniraDogađaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 359);
            this.Controls.Add(this.prijaviTim);
            this.Controls.Add(this.samostalnaPrijava);
            this.Controls.Add(this.pretrazivanjeTXB);
            this.Controls.Add(this.natragBTN);
            this.Controls.Add(this.pretraziBTN);
            this.Controls.Add(this.pregledDTG);
            this.Controls.Add(this.Sport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PregledTurniraDogađaja";
            this.Text = "PregledTurniraDogađaja";
            this.Load += new System.EventHandler(this.PregledTurniraDogađaja_Load);
            this.Sport.ResumeLayout(false);
            this.Sport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Sport;
        private System.Windows.Forms.CheckBox nogometCB;
        private System.Windows.Forms.CheckBox kosarkaCB;
        private System.Windows.Forms.CheckBox rukometCB;
        private System.Windows.Forms.DataGridView pregledDTG;
        private System.Windows.Forms.Button pretraziBTN;
        private System.Windows.Forms.Button natragBTN;
        private System.Windows.Forms.TextBox pretrazivanjeTXB;
        private System.Windows.Forms.Button samostalnaPrijava;
        private System.Windows.Forms.Button prijaviTim;
    }
}