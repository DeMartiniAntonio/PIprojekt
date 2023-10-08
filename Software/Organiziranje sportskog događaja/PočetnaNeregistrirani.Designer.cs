namespace Organiziranje_sportskog_događaja
{
    partial class PočetnaNeregistrirani
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
            this.kreirajTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaKaoKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaKaoModeratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaKaoOrganizacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.slobodnoRadio = new System.Windows.Forms.RadioButton();
            this.odigranoRadio = new System.Windows.Forms.RadioButton();
            this.rukometCheckbox = new System.Windows.Forms.CheckBox();
            this.kosarkaCheckbox = new System.Windows.Forms.CheckBox();
            this.nogometCheckbox = new System.Windows.Forms.CheckBox();
            this.pregledDogadajaBtn = new System.Windows.Forms.Button();
            this.dogadajiDgv = new System.Windows.Forms.DataGridView();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pogledajOrganizacijuBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timoviCmb = new System.Windows.Forms.ComboBox();
            this.pogledajTimBtn = new System.Windows.Forms.Button();
            this.pogledajIgracaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.igraciCmb = new System.Windows.Forms.ComboBox();
            this.organizacijeCmb = new System.Windows.Forms.ComboBox();
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
            // kreirajTimToolStripMenuItem
            // 
            this.kreirajTimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registracijaKaoKorisnikToolStripMenuItem,
            this.registracijaKaoModeratorToolStripMenuItem,
            this.registracijaKaoOrganizacijaToolStripMenuItem});
            this.kreirajTimToolStripMenuItem.Name = "kreirajTimToolStripMenuItem";
            this.kreirajTimToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.kreirajTimToolStripMenuItem.Text = "Registriraj se";
            // 
            // registracijaKaoKorisnikToolStripMenuItem
            // 
            this.registracijaKaoKorisnikToolStripMenuItem.Name = "registracijaKaoKorisnikToolStripMenuItem";
            this.registracijaKaoKorisnikToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.registracijaKaoKorisnikToolStripMenuItem.Text = "Registracija kao korisnik";
            this.registracijaKaoKorisnikToolStripMenuItem.Click += new System.EventHandler(this.registracijaKaoKorisnikToolStripMenuItem_Click);
            // 
            // registracijaKaoModeratorToolStripMenuItem
            // 
            this.registracijaKaoModeratorToolStripMenuItem.Name = "registracijaKaoModeratorToolStripMenuItem";
            this.registracijaKaoModeratorToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.registracijaKaoModeratorToolStripMenuItem.Text = "Registracija kao moderator";
            this.registracijaKaoModeratorToolStripMenuItem.Click += new System.EventHandler(this.registracijaKaoModeratorToolStripMenuItem_Click);
            // 
            // registracijaKaoOrganizacijaToolStripMenuItem
            // 
            this.registracijaKaoOrganizacijaToolStripMenuItem.Name = "registracijaKaoOrganizacijaToolStripMenuItem";
            this.registracijaKaoOrganizacijaToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.registracijaKaoOrganizacijaToolStripMenuItem.Text = "Registracija kao organizacija";
            this.registracijaKaoOrganizacijaToolStripMenuItem.Click += new System.EventHandler(this.registracijaKaoOrganizacijaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slobodnoRadio);
            this.groupBox1.Controls.Add(this.odigranoRadio);
            this.groupBox1.Controls.Add(this.rukometCheckbox);
            this.groupBox1.Controls.Add(this.kosarkaCheckbox);
            this.groupBox1.Controls.Add(this.nogometCheckbox);
            this.groupBox1.Controls.Add(this.pregledDogadajaBtn);
            this.groupBox1.Controls.Add(this.dogadajiDgv);
            this.groupBox1.Location = new System.Drawing.Point(16, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 332);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled događaja";
            // 
            // slobodnoRadio
            // 
            this.slobodnoRadio.AutoSize = true;
            this.slobodnoRadio.Location = new System.Drawing.Point(231, 280);
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
            this.odigranoRadio.Location = new System.Drawing.Point(63, 280);
            this.odigranoRadio.Name = "odigranoRadio";
            this.odigranoRadio.Size = new System.Drawing.Size(136, 20);
            this.odigranoRadio.TabIndex = 10;
            this.odigranoRadio.TabStop = true;
            this.odigranoRadio.Text = "Odigrani događaji";
            this.odigranoRadio.UseVisualStyleBackColor = true;
            this.odigranoRadio.CheckedChanged += new System.EventHandler(this.odigranoRadio_CheckedChanged_1);
            // 
            // rukometCheckbox
            // 
            this.rukometCheckbox.AutoSize = true;
            this.rukometCheckbox.Location = new System.Drawing.Point(406, 19);
            this.rukometCheckbox.Name = "rukometCheckbox";
            this.rukometCheckbox.Size = new System.Drawing.Size(83, 20);
            this.rukometCheckbox.TabIndex = 9;
            this.rukometCheckbox.Text = "Rukomet";
            this.rukometCheckbox.UseVisualStyleBackColor = true;
            // 
            // kosarkaCheckbox
            // 
            this.kosarkaCheckbox.AutoSize = true;
            this.kosarkaCheckbox.Location = new System.Drawing.Point(276, 19);
            this.kosarkaCheckbox.Name = "kosarkaCheckbox";
            this.kosarkaCheckbox.Size = new System.Drawing.Size(79, 20);
            this.kosarkaCheckbox.TabIndex = 8;
            this.kosarkaCheckbox.Text = "Košarka";
            this.kosarkaCheckbox.UseVisualStyleBackColor = true;
            // 
            // nogometCheckbox
            // 
            this.nogometCheckbox.AutoSize = true;
            this.nogometCheckbox.Location = new System.Drawing.Point(140, 19);
            this.nogometCheckbox.Name = "nogometCheckbox";
            this.nogometCheckbox.Size = new System.Drawing.Size(85, 20);
            this.nogometCheckbox.TabIndex = 7;
            this.nogometCheckbox.Text = "Nogomet";
            this.nogometCheckbox.UseVisualStyleBackColor = true;
            // 
            // pregledDogadajaBtn
            // 
            this.pregledDogadajaBtn.Location = new System.Drawing.Point(555, 261);
            this.pregledDogadajaBtn.Name = "pregledDogadajaBtn";
            this.pregledDogadajaBtn.Size = new System.Drawing.Size(117, 58);
            this.pregledDogadajaBtn.TabIndex = 6;
            this.pregledDogadajaBtn.Text = "Pregled događaja";
            this.pregledDogadajaBtn.UseVisualStyleBackColor = true;
            this.pregledDogadajaBtn.Click += new System.EventHandler(this.pregledDogadajaBtn_Click);
            // 
            // dogadajiDgv
            // 
            this.dogadajiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogadajiDgv.Location = new System.Drawing.Point(6, 55);
            this.dogadajiDgv.Name = "dogadajiDgv";
            this.dogadajiDgv.RowHeadersWidth = 51;
            this.dogadajiDgv.RowTemplate.Height = 24;
            this.dogadajiDgv.Size = new System.Drawing.Size(666, 202);
            this.dogadajiDgv.TabIndex = 1;
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.loginToolStripMenuItem.Text = "Prijavi se";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.kreirajTimToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 28);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pogledajOrganizacijuBtn
            // 
            this.pogledajOrganizacijuBtn.Location = new System.Drawing.Point(539, 165);
            this.pogledajOrganizacijuBtn.Name = "pogledajOrganizacijuBtn";
            this.pogledajOrganizacijuBtn.Size = new System.Drawing.Size(146, 30);
            this.pogledajOrganizacijuBtn.TabIndex = 53;
            this.pogledajOrganizacijuBtn.Text = "Pogledaj organizaciju";
            this.pogledajOrganizacijuBtn.UseVisualStyleBackColor = true;
            this.pogledajOrganizacijuBtn.Click += new System.EventHandler(this.pogledajOrganizacijuBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Timovi:";
            // 
            // timoviCmb
            // 
            this.timoviCmb.FormattingEnabled = true;
            this.timoviCmb.Location = new System.Drawing.Point(375, 110);
            this.timoviCmb.Name = "timoviCmb";
            this.timoviCmb.Size = new System.Drawing.Size(158, 24);
            this.timoviCmb.TabIndex = 48;
            // 
            // pogledajTimBtn
            // 
            this.pogledajTimBtn.Location = new System.Drawing.Point(539, 107);
            this.pogledajTimBtn.Name = "pogledajTimBtn";
            this.pogledajTimBtn.Size = new System.Drawing.Size(146, 29);
            this.pogledajTimBtn.TabIndex = 50;
            this.pogledajTimBtn.Text = "Pogledaj tim";
            this.pogledajTimBtn.UseVisualStyleBackColor = true;
            this.pogledajTimBtn.Click += new System.EventHandler(this.pogledajTimBtn_Click);
            // 
            // pogledajIgracaBtn
            // 
            this.pogledajIgracaBtn.Location = new System.Drawing.Point(539, 42);
            this.pogledajIgracaBtn.Name = "pogledajIgracaBtn";
            this.pogledajIgracaBtn.Size = new System.Drawing.Size(146, 30);
            this.pogledajIgracaBtn.TabIndex = 47;
            this.pogledajIgracaBtn.Text = "Pogledaj igrača";
            this.pogledajIgracaBtn.UseVisualStyleBackColor = true;
            this.pogledajIgracaBtn.Click += new System.EventHandler(this.pogledajIgracaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Igrači:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Sportske organizacije:";
            // 
            // igraciCmb
            // 
            this.igraciCmb.FormattingEnabled = true;
            this.igraciCmb.Location = new System.Drawing.Point(375, 46);
            this.igraciCmb.Name = "igraciCmb";
            this.igraciCmb.Size = new System.Drawing.Size(158, 24);
            this.igraciCmb.TabIndex = 45;
            // 
            // organizacijeCmb
            // 
            this.organizacijeCmb.FormattingEnabled = true;
            this.organizacijeCmb.Location = new System.Drawing.Point(375, 169);
            this.organizacijeCmb.Name = "organizacijeCmb";
            this.organizacijeCmb.Size = new System.Drawing.Size(158, 24);
            this.organizacijeCmb.TabIndex = 51;
            // 
            // PočetnaNeregistrirani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pogledajOrganizacijuBtn);
            this.Controls.Add(this.organizacijeCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timoviCmb);
            this.Controls.Add(this.pogledajTimBtn);
            this.Controls.Add(this.pogledajIgracaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.igraciCmb);
            this.Name = "PočetnaNeregistrirani";
            this.Text = "PočetnaNeregistrirani";
            this.Load += new System.EventHandler(this.PočetnaNeregistrirani_Load);
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
        private System.Windows.Forms.ToolStripMenuItem kreirajTimToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton slobodnoRadio;
        private System.Windows.Forms.RadioButton odigranoRadio;
        private System.Windows.Forms.CheckBox rukometCheckbox;
        private System.Windows.Forms.CheckBox kosarkaCheckbox;
        private System.Windows.Forms.CheckBox nogometCheckbox;
        private System.Windows.Forms.Button pregledDogadajaBtn;
        private System.Windows.Forms.DataGridView dogadajiDgv;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button pogledajOrganizacijuBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timoviCmb;
        private System.Windows.Forms.Button pogledajTimBtn;
        private System.Windows.Forms.Button pogledajIgracaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox igraciCmb;
        private System.Windows.Forms.ToolStripMenuItem registracijaKaoKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracijaKaoModeratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracijaKaoOrganizacijaToolStripMenuItem;
        private System.Windows.Forms.ComboBox organizacijeCmb;
    }
}