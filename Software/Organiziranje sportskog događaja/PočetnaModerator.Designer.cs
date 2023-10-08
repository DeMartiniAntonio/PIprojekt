namespace Organiziranje_sportskog_događaja
{
    partial class PočetnaModerator
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
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodijeljeniDogađajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.slobodnoRadio = new System.Windows.Forms.RadioButton();
            this.odigranoRadio = new System.Windows.Forms.RadioButton();
            this.dogadajBtn = new System.Windows.Forms.Button();
            this.dogadajiDgv = new System.Windows.Forms.DataGridView();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prijavaNaTurnirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orgBtn = new System.Windows.Forms.Button();
            this.organizacijeCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timoviCmb = new System.Windows.Forms.ComboBox();
            this.timBtn = new System.Windows.Forms.Button();
            this.igracBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.igraciCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajiDgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // dodijeljeniDogađajiToolStripMenuItem
            // 
            this.dodijeljeniDogađajiToolStripMenuItem.Name = "dodijeljeniDogađajiToolStripMenuItem";
            this.dodijeljeniDogađajiToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.dodijeljeniDogađajiToolStripMenuItem.Text = "Dodijeljeni događaji";
            this.dodijeljeniDogađajiToolStripMenuItem.Click += new System.EventHandler(this.dodijeljeniDogađajiToolStripMenuItem_Click);
            // 
            // kreirajTimToolStripMenuItem
            // 
            this.kreirajTimToolStripMenuItem.Name = "kreirajTimToolStripMenuItem";
            this.kreirajTimToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.kreirajTimToolStripMenuItem.Text = "Kreiraj tim";
            this.kreirajTimToolStripMenuItem.Click += new System.EventHandler(this.kreirajTimToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slobodnoRadio);
            this.groupBox1.Controls.Add(this.odigranoRadio);
            this.groupBox1.Controls.Add(this.dogadajBtn);
            this.groupBox1.Controls.Add(this.dogadajiDgv);
            this.groupBox1.Location = new System.Drawing.Point(15, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(692, 332);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled događaja";
            // 
            // slobodnoRadio
            // 
            this.slobodnoRadio.AutoSize = true;
            this.slobodnoRadio.Location = new System.Drawing.Point(231, 281);
            this.slobodnoRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slobodnoRadio.Name = "slobodnoRadio";
            this.slobodnoRadio.Size = new System.Drawing.Size(147, 20);
            this.slobodnoRadio.TabIndex = 11;
            this.slobodnoRadio.TabStop = true;
            this.slobodnoRadio.Text = "Slobodno za prijavu";
            this.slobodnoRadio.UseVisualStyleBackColor = true;
            this.slobodnoRadio.CheckedChanged += new System.EventHandler(this.slobodnoRadio_CheckedChanged);
            // 
            // odigranoRadio
            // 
            this.odigranoRadio.AutoSize = true;
            this.odigranoRadio.Location = new System.Drawing.Point(63, 281);
            this.odigranoRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odigranoRadio.Name = "odigranoRadio";
            this.odigranoRadio.Size = new System.Drawing.Size(136, 20);
            this.odigranoRadio.TabIndex = 10;
            this.odigranoRadio.TabStop = true;
            this.odigranoRadio.Text = "Odigrani događaji";
            this.odigranoRadio.UseVisualStyleBackColor = true;
            this.odigranoRadio.CheckedChanged += new System.EventHandler(this.odigranoRadio_CheckedChanged);
            // 
            // dogadajBtn
            // 
            this.dogadajBtn.Location = new System.Drawing.Point(554, 262);
            this.dogadajBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dogadajBtn.Name = "dogadajBtn";
            this.dogadajBtn.Size = new System.Drawing.Size(117, 58);
            this.dogadajBtn.TabIndex = 6;
            this.dogadajBtn.Text = "Pregled događaja";
            this.dogadajBtn.UseVisualStyleBackColor = true;
            this.dogadajBtn.Click += new System.EventHandler(this.dogadajBtn_Click);
            // 
            // dogadajiDgv
            // 
            this.dogadajiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogadajiDgv.Location = new System.Drawing.Point(5, 55);
            this.dogadajiDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dogadajiDgv.Name = "dogadajiDgv";
            this.dogadajiDgv.RowHeadersWidth = 51;
            this.dogadajiDgv.RowTemplate.Height = 24;
            this.dogadajiDgv.Size = new System.Drawing.Size(667, 202);
            this.dogadajiDgv.TabIndex = 1;
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.loginToolStripMenuItem.Text = "Profil";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.kreirajTimToolStripMenuItem,
            this.prijavaNaTurnirToolStripMenuItem,
            this.dodijeljeniDogađajiToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 28);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prijavaNaTurnirToolStripMenuItem
            // 
            this.prijavaNaTurnirToolStripMenuItem.Name = "prijavaNaTurnirToolStripMenuItem";
            this.prijavaNaTurnirToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.prijavaNaTurnirToolStripMenuItem.Text = "Prijava na turnir";
            this.prijavaNaTurnirToolStripMenuItem.Click += new System.EventHandler(this.prijavaNaTurnirToolStripMenuItem_Click);
            // 
            // orgBtn
            // 
            this.orgBtn.Location = new System.Drawing.Point(539, 162);
            this.orgBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orgBtn.Name = "orgBtn";
            this.orgBtn.Size = new System.Drawing.Size(147, 30);
            this.orgBtn.TabIndex = 53;
            this.orgBtn.Text = "Pogledaj organizaciju";
            this.orgBtn.UseVisualStyleBackColor = true;
            this.orgBtn.Click += new System.EventHandler(this.orgBtn_Click);
            // 
            // organizacijeCmb
            // 
            this.organizacijeCmb.FormattingEnabled = true;
            this.organizacijeCmb.Location = new System.Drawing.Point(373, 166);
            this.organizacijeCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.organizacijeCmb.Name = "organizacijeCmb";
            this.organizacijeCmb.Size = new System.Drawing.Size(159, 24);
            this.organizacijeCmb.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Timovi:";
            // 
            // timoviCmb
            // 
            this.timoviCmb.FormattingEnabled = true;
            this.timoviCmb.Location = new System.Drawing.Point(373, 107);
            this.timoviCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timoviCmb.Name = "timoviCmb";
            this.timoviCmb.Size = new System.Drawing.Size(159, 24);
            this.timoviCmb.TabIndex = 48;
            // 
            // timBtn
            // 
            this.timBtn.Location = new System.Drawing.Point(539, 103);
            this.timBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timBtn.Name = "timBtn";
            this.timBtn.Size = new System.Drawing.Size(147, 30);
            this.timBtn.TabIndex = 50;
            this.timBtn.Text = "Pogledaj tim";
            this.timBtn.UseVisualStyleBackColor = true;
            this.timBtn.Click += new System.EventHandler(this.timBtn_Click);
            // 
            // igracBtn
            // 
            this.igracBtn.Location = new System.Drawing.Point(539, 39);
            this.igracBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.igracBtn.Name = "igracBtn";
            this.igracBtn.Size = new System.Drawing.Size(147, 30);
            this.igracBtn.TabIndex = 47;
            this.igracBtn.Text = "Pogledaj igrača";
            this.igracBtn.UseVisualStyleBackColor = true;
            this.igracBtn.Click += new System.EventHandler(this.igracBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Igrači:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Sportske organizacije:";
            // 
            // igraciCmb
            // 
            this.igraciCmb.FormattingEnabled = true;
            this.igraciCmb.Location = new System.Drawing.Point(373, 43);
            this.igraciCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.igraciCmb.Name = "igraciCmb";
            this.igraciCmb.Size = new System.Drawing.Size(159, 24);
            this.igraciCmb.TabIndex = 45;
            // 
            // PočetnaModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.orgBtn);
            this.Controls.Add(this.organizacijeCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timoviCmb);
            this.Controls.Add(this.timBtn);
            this.Controls.Add(this.igracBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.igraciCmb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PočetnaModerator";
            this.Text = "PočetnaModerator";
            this.Load += new System.EventHandler(this.PočetnaModerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajiDgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodijeljeniDogađajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajTimToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton slobodnoRadio;
        private System.Windows.Forms.RadioButton odigranoRadio;
        private System.Windows.Forms.Button dogadajBtn;
        private System.Windows.Forms.DataGridView dogadajiDgv;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button orgBtn;
        private System.Windows.Forms.ComboBox organizacijeCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timoviCmb;
        private System.Windows.Forms.Button timBtn;
        private System.Windows.Forms.Button igracBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox igraciCmb;
        private System.Windows.Forms.ToolStripMenuItem prijavaNaTurnirToolStripMenuItem;
    }
}