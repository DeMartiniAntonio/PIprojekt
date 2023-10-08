namespace Organiziranje_sportskog_događaja
{
    partial class AdministratorOdobriDogađaje
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
            this.dogadajiNaCekanjuDgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajBtn = new System.Windows.Forms.Button();
            this.prihvaceniDogadajiDgv = new System.Windows.Forms.DataGridView();
            this.dodajModeratoraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajiNaCekanjuDgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prihvaceniDogadajiDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dogadajiNaCekanjuDgv
            // 
            this.dogadajiNaCekanjuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogadajiNaCekanjuDgv.Location = new System.Drawing.Point(12, 48);
            this.dogadajiNaCekanjuDgv.Name = "dogadajiNaCekanjuDgv";
            this.dogadajiNaCekanjuDgv.RowHeadersWidth = 51;
            this.dogadajiNaCekanjuDgv.RowTemplate.Height = 24;
            this.dogadajiNaCekanjuDgv.Size = new System.Drawing.Size(776, 237);
            this.dogadajiNaCekanjuDgv.TabIndex = 62;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.loginToolStripMenuItem.Text = "Profil";
            // 
            // kreirajTimToolStripMenuItem
            // 
            this.kreirajTimToolStripMenuItem.Name = "kreirajTimToolStripMenuItem";
            this.kreirajTimToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.kreirajTimToolStripMenuItem.Text = "Kreiraj tim";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // pregledajBtn
            // 
            this.pregledajBtn.Location = new System.Drawing.Point(679, 291);
            this.pregledajBtn.Name = "pregledajBtn";
            this.pregledajBtn.Size = new System.Drawing.Size(109, 69);
            this.pregledajBtn.TabIndex = 63;
            this.pregledajBtn.Text = "Pregledaj ";
            this.pregledajBtn.UseVisualStyleBackColor = true;
            this.pregledajBtn.Click += new System.EventHandler(this.pregledajBtn_Click);
            // 
            // prihvaceniDogadajiDgv
            // 
            this.prihvaceniDogadajiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prihvaceniDogadajiDgv.Location = new System.Drawing.Point(12, 366);
            this.prihvaceniDogadajiDgv.Name = "prihvaceniDogadajiDgv";
            this.prihvaceniDogadajiDgv.RowHeadersWidth = 51;
            this.prihvaceniDogadajiDgv.RowTemplate.Height = 24;
            this.prihvaceniDogadajiDgv.Size = new System.Drawing.Size(776, 237);
            this.prihvaceniDogadajiDgv.TabIndex = 64;
            // 
            // dodajModeratoraBtn
            // 
            this.dodajModeratoraBtn.Location = new System.Drawing.Point(679, 609);
            this.dodajModeratoraBtn.Name = "dodajModeratoraBtn";
            this.dodajModeratoraBtn.Size = new System.Drawing.Size(109, 69);
            this.dodajModeratoraBtn.TabIndex = 65;
            this.dodajModeratoraBtn.Text = "Dodaj moderatora";
            this.dodajModeratoraBtn.UseVisualStyleBackColor = true;
            this.dodajModeratoraBtn.Click += new System.EventHandler(this.dodajModeratoraBtn_Click);
            // 
            // AdministratorOdobriDogađaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.prihvaceniDogadajiDgv);
            this.Controls.Add(this.dodajModeratoraBtn);
            this.Controls.Add(this.dogadajiNaCekanjuDgv);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pregledajBtn);
            this.Name = "AdministratorOdobriDogađaje";
            this.Text = "AdministratorOdobriDogađaje";
            this.Load += new System.EventHandler(this.AdministratorOdobriDogađaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogadajiNaCekanjuDgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prihvaceniDogadajiDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dogadajiNaCekanjuDgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.Button pregledajBtn;
        private System.Windows.Forms.DataGridView prihvaceniDogadajiDgv;
        private System.Windows.Forms.Button dodajModeratoraBtn;
    }
}