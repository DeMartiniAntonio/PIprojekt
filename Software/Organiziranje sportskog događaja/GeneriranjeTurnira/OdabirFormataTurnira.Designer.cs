namespace Organiziranje_sportskog_događaja
{
    partial class OdabirFormataTurnira
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
            this.generirajBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brGrupaTXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prolaziTXB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grupnafazaCB = new System.Windows.Forms.CheckBox();
            this.knockoutCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generirajBTN
            // 
            this.generirajBTN.Location = new System.Drawing.Point(25, 297);
            this.generirajBTN.Name = "generirajBTN";
            this.generirajBTN.Size = new System.Drawing.Size(220, 60);
            this.generirajBTN.TabIndex = 13;
            this.generirajBTN.Text = "Generiraj turnir";
            this.generirajBTN.UseVisualStyleBackColor = true;
            this.generirajBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Odaberi format turnira";
            // 
            // brGrupaTXB
            // 
            this.brGrupaTXB.Location = new System.Drawing.Point(16, 40);
            this.brGrupaTXB.Name = "brGrupaTXB";
            this.brGrupaTXB.Size = new System.Drawing.Size(100, 20);
            this.brGrupaTXB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite broj grupa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Koliko timova prolazi u knockout fazu:";
            // 
            // prolaziTXB
            // 
            this.prolaziTXB.Location = new System.Drawing.Point(16, 90);
            this.prolaziTXB.Name = "prolaziTXB";
            this.prolaziTXB.Size = new System.Drawing.Size(100, 20);
            this.prolaziTXB.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grupnafazaCB);
            this.groupBox1.Controls.Add(this.knockoutCB);
            this.groupBox1.Location = new System.Drawing.Point(25, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 90);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir formata turnira";
            // 
            // grupnafazaCB
            // 
            this.grupnafazaCB.AutoSize = true;
            this.grupnafazaCB.Location = new System.Drawing.Point(16, 58);
            this.grupnafazaCB.Name = "grupnafazaCB";
            this.grupnafazaCB.Size = new System.Drawing.Size(141, 17);
            this.grupnafazaCB.TabIndex = 10;
            this.grupnafazaCB.Text = "Format s grupnom fazom";
            this.grupnafazaCB.UseVisualStyleBackColor = true;
            this.grupnafazaCB.CheckedChanged += new System.EventHandler(this.grupnafazaCB_CheckedChanged);
            // 
            // knockoutCB
            // 
            this.knockoutCB.AutoSize = true;
            this.knockoutCB.Location = new System.Drawing.Point(16, 35);
            this.knockoutCB.Name = "knockoutCB";
            this.knockoutCB.Size = new System.Drawing.Size(104, 17);
            this.knockoutCB.TabIndex = 9;
            this.knockoutCB.Text = "Knockout format";
            this.knockoutCB.UseVisualStyleBackColor = true;
            this.knockoutCB.CheckedChanged += new System.EventHandler(this.knockoutCB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brGrupaTXB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prolaziTXB);
            this.groupBox2.Location = new System.Drawing.Point(25, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 140);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postavke za grupnu fazu";
            // 
            // OdabirFormataTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 366);
            this.Controls.Add(this.generirajBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OdabirFormataTurnira";
            this.Text = "OdabirFormataTurnira";
            this.Load += new System.EventHandler(this.OdabirFormataTurnira_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generirajBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brGrupaTXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prolaziTXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox grupnafazaCB;
        private System.Windows.Forms.CheckBox knockoutCB;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}