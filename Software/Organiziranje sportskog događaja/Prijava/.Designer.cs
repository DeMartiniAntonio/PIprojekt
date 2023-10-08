namespace Organiziranje_sportskog_događaja
{
    partial class Prijava
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
            this.prijaviSeBTN = new System.Windows.Forms.Button();
            this.natragBTN = new System.Windows.Forms.Button();
            this.lozinkaTBX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.korisnickoImeTXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijaviSeBTN
            // 
            this.prijaviSeBTN.Location = new System.Drawing.Point(155, 164);
            this.prijaviSeBTN.Name = "prijaviSeBTN";
            this.prijaviSeBTN.Size = new System.Drawing.Size(96, 46);
            this.prijaviSeBTN.TabIndex = 15;
            this.prijaviSeBTN.Text = "Prijavi se";
            this.prijaviSeBTN.UseVisualStyleBackColor = true;
            this.prijaviSeBTN.Click += new System.EventHandler(this.prijaviSeBTN_Click);
            // 
            // natragBTN
            // 
            this.natragBTN.Location = new System.Drawing.Point(260, 164);
            this.natragBTN.Name = "natragBTN";
            this.natragBTN.Size = new System.Drawing.Size(96, 46);
            this.natragBTN.TabIndex = 14;
            this.natragBTN.Text = "Natrag";
            this.natragBTN.UseVisualStyleBackColor = true;
            this.natragBTN.Click += new System.EventHandler(this.natragBTN_Click);
            // 
            // lozinkaTBX
            // 
            this.lozinkaTBX.Location = new System.Drawing.Point(122, 117);
            this.lozinkaTBX.Name = "lozinkaTBX";
            this.lozinkaTBX.PasswordChar = '*';
            this.lozinkaTBX.Size = new System.Drawing.Size(235, 20);
            this.lozinkaTBX.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lozinka:";
            // 
            // korisnickoImeTXB
            // 
            this.korisnickoImeTXB.Location = new System.Drawing.Point(122, 91);
            this.korisnickoImeTXB.Name = "korisnickoImeTXB";
            this.korisnickoImeTXB.Size = new System.Drawing.Size(235, 20);
            this.korisnickoImeTXB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prijavi se";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 240);
            this.Controls.Add(this.prijaviSeBTN);
            this.Controls.Add(this.natragBTN);
            this.Controls.Add(this.lozinkaTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.korisnickoImeTXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijaviSeBTN;
        private System.Windows.Forms.Button natragBTN;
        private System.Windows.Forms.TextBox lozinkaTBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox korisnickoImeTXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}