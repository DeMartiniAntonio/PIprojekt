namespace Organiziranje_sportskog_događaja
{
    partial class KreiranjeTima
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
            this.zaPristupTimu = new System.Windows.Forms.GroupBox();
            this.uiPristupi = new System.Windows.Forms.Button();
            this.uiUnosPristupnogKoda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiOdaberiteOpciju = new System.Windows.Forms.ComboBox();
            this.zaKreiranjeTima = new System.Windows.Forms.GroupBox();
            this.uiPrikazPristupnogKoda = new System.Windows.Forms.TextBox();
            this.uiKreiraj = new System.Windows.Forms.Button();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiOdaberiteVelicinu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelaPrikazKoda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiNatrag = new System.Windows.Forms.Button();
            this.uiKopiraj = new System.Windows.Forms.Button();
            this.zaPristupTimu.SuspendLayout();
            this.zaKreiranjeTima.SuspendLayout();
            this.SuspendLayout();
            // 
            // zaPristupTimu
            // 
            this.zaPristupTimu.Controls.Add(this.uiPristupi);
            this.zaPristupTimu.Controls.Add(this.uiUnosPristupnogKoda);
            this.zaPristupTimu.Controls.Add(this.label5);
            this.zaPristupTimu.Location = new System.Drawing.Point(24, 61);
            this.zaPristupTimu.Name = "zaPristupTimu";
            this.zaPristupTimu.Size = new System.Drawing.Size(419, 127);
            this.zaPristupTimu.TabIndex = 11;
            this.zaPristupTimu.TabStop = false;
            this.zaPristupTimu.Text = "Pristup timu";
            // 
            // uiPristupi
            // 
            this.uiPristupi.Location = new System.Drawing.Point(255, 75);
            this.uiPristupi.Name = "uiPristupi";
            this.uiPristupi.Size = new System.Drawing.Size(110, 36);
            this.uiPristupi.TabIndex = 9;
            this.uiPristupi.Text = "Pristupi";
            this.uiPristupi.UseVisualStyleBackColor = true;
            this.uiPristupi.Click += new System.EventHandler(this.uiPristupi_Click);
            // 
            // uiUnosPristupnogKoda
            // 
            this.uiUnosPristupnogKoda.Location = new System.Drawing.Point(188, 34);
            this.uiUnosPristupnogKoda.Name = "uiUnosPristupnogKoda";
            this.uiUnosPristupnogKoda.Size = new System.Drawing.Size(177, 22);
            this.uiUnosPristupnogKoda.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unesite pristupni kod: ";
            // 
            // uiOdaberiteOpciju
            // 
            this.uiOdaberiteOpciju.FormattingEnabled = true;
            this.uiOdaberiteOpciju.Location = new System.Drawing.Point(139, 18);
            this.uiOdaberiteOpciju.Name = "uiOdaberiteOpciju";
            this.uiOdaberiteOpciju.Size = new System.Drawing.Size(139, 24);
            this.uiOdaberiteOpciju.TabIndex = 9;
            this.uiOdaberiteOpciju.SelectedIndexChanged += new System.EventHandler(this.uiOdaberiteOpciju_SelectedIndexChanged);
            // 
            // zaKreiranjeTima
            // 
            this.zaKreiranjeTima.Controls.Add(this.uiKopiraj);
            this.zaKreiranjeTima.Controls.Add(this.uiPrikazPristupnogKoda);
            this.zaKreiranjeTima.Controls.Add(this.uiKreiraj);
            this.zaKreiranjeTima.Controls.Add(this.uiUnosNaziva);
            this.zaKreiranjeTima.Controls.Add(this.label4);
            this.zaKreiranjeTima.Controls.Add(this.uiOdaberiteVelicinu);
            this.zaKreiranjeTima.Controls.Add(this.label3);
            this.zaKreiranjeTima.Controls.Add(this.labelaPrikazKoda);
            this.zaKreiranjeTima.Location = new System.Drawing.Point(24, 61);
            this.zaKreiranjeTima.Name = "zaKreiranjeTima";
            this.zaKreiranjeTima.Size = new System.Drawing.Size(419, 215);
            this.zaKreiranjeTima.TabIndex = 10;
            this.zaKreiranjeTima.TabStop = false;
            this.zaKreiranjeTima.Text = "Kreiranje tima";
            // 
            // uiPrikazPristupnogKoda
            // 
            this.uiPrikazPristupnogKoda.Location = new System.Drawing.Point(128, 160);
            this.uiPrikazPristupnogKoda.Name = "uiPrikazPristupnogKoda";
            this.uiPrikazPristupnogKoda.Size = new System.Drawing.Size(148, 22);
            this.uiPrikazPristupnogKoda.TabIndex = 9;
            // 
            // uiKreiraj
            // 
            this.uiKreiraj.Location = new System.Drawing.Point(255, 109);
            this.uiKreiraj.Name = "uiKreiraj";
            this.uiKreiraj.Size = new System.Drawing.Size(110, 36);
            this.uiKreiraj.TabIndex = 8;
            this.uiKreiraj.Text = "Kreiraj";
            this.uiKreiraj.UseVisualStyleBackColor = true;
            this.uiKreiraj.Click += new System.EventHandler(this.uiKreiraj_Click);
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(188, 71);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(177, 22);
            this.uiUnosNaziva.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unesite naziv tima: ";
            // 
            // uiOdaberiteVelicinu
            // 
            this.uiOdaberiteVelicinu.FormattingEnabled = true;
            this.uiOdaberiteVelicinu.Location = new System.Drawing.Point(188, 27);
            this.uiOdaberiteVelicinu.Name = "uiOdaberiteVelicinu";
            this.uiOdaberiteVelicinu.Size = new System.Drawing.Size(177, 24);
            this.uiOdaberiteVelicinu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odaberite veličinu tima: ";
            // 
            // labelaPrikazKoda
            // 
            this.labelaPrikazKoda.AutoSize = true;
            this.labelaPrikazKoda.Location = new System.Drawing.Point(6, 163);
            this.labelaPrikazKoda.Name = "labelaPrikazKoda";
            this.labelaPrikazKoda.Size = new System.Drawing.Size(116, 16);
            this.labelaPrikazKoda.TabIndex = 4;
            this.labelaPrikazKoda.Text = "Vaš pristupni kod: ";
            this.labelaPrikazKoda.Click += new System.EventHandler(this.KreiranjeTima_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Odaberite opciju: ";
            // 
            // uiNatrag
            // 
            this.uiNatrag.Location = new System.Drawing.Point(333, 12);
            this.uiNatrag.Name = "uiNatrag";
            this.uiNatrag.Size = new System.Drawing.Size(110, 36);
            this.uiNatrag.TabIndex = 10;
            this.uiNatrag.Text = "Natrag";
            this.uiNatrag.UseVisualStyleBackColor = true;
            this.uiNatrag.Click += new System.EventHandler(this.uiNatrag_Click);
            // 
            // uiKopiraj
            // 
            this.uiKopiraj.Location = new System.Drawing.Point(282, 155);
            this.uiKopiraj.Name = "uiKopiraj";
            this.uiKopiraj.Size = new System.Drawing.Size(83, 31);
            this.uiKopiraj.TabIndex = 10;
            this.uiKopiraj.Text = "Kopiraj";
            this.uiKopiraj.UseVisualStyleBackColor = true;
            this.uiKopiraj.Click += new System.EventHandler(this.uiKopiraj_Click);
            // 
            // KreiranjeTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 294);
            this.Controls.Add(this.uiNatrag);
            this.Controls.Add(this.zaPristupTimu);
            this.Controls.Add(this.uiOdaberiteOpciju);
            this.Controls.Add(this.zaKreiranjeTima);
            this.Controls.Add(this.label1);
            this.Name = "KreiranjeTima";
            this.Text = "Kreiranje_tima";
            this.Load += new System.EventHandler(this.KreiranjeTima_Load);
            this.zaPristupTimu.ResumeLayout(false);
            this.zaPristupTimu.PerformLayout();
            this.zaKreiranjeTima.ResumeLayout(false);
            this.zaKreiranjeTima.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox zaPristupTimu;
        private System.Windows.Forms.Button uiPristupi;
        private System.Windows.Forms.TextBox uiUnosPristupnogKoda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uiOdaberiteOpciju;
        private System.Windows.Forms.GroupBox zaKreiranjeTima;
        private System.Windows.Forms.Button uiKreiraj;
        private System.Windows.Forms.TextBox uiUnosNaziva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uiOdaberiteVelicinu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelaPrikazKoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiPrikazPristupnogKoda;
        private System.Windows.Forms.Button uiNatrag;
        private System.Windows.Forms.Button uiKopiraj;
    }
}