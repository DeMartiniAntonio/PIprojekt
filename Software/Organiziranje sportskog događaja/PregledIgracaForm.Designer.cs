namespace Organiziranje_sportskog_događaja
{
    partial class PregledIgracaForm
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
            this.korimeTxt = new System.Windows.Forms.TextBox();
            this.prezimeTxt = new System.Windows.Forms.TextBox();
            this.imeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korimeTxt
            // 
            this.korimeTxt.Location = new System.Drawing.Point(133, 82);
            this.korimeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korimeTxt.Name = "korimeTxt";
            this.korimeTxt.ReadOnly = true;
            this.korimeTxt.Size = new System.Drawing.Size(213, 22);
            this.korimeTxt.TabIndex = 122;
            // 
            // prezimeTxt
            // 
            this.prezimeTxt.Location = new System.Drawing.Point(133, 56);
            this.prezimeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezimeTxt.Name = "prezimeTxt";
            this.prezimeTxt.ReadOnly = true;
            this.prezimeTxt.Size = new System.Drawing.Size(213, 22);
            this.prezimeTxt.TabIndex = 119;
            // 
            // imeTxt
            // 
            this.imeTxt.Location = new System.Drawing.Point(133, 29);
            this.imeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeTxt.Name = "imeTxt";
            this.imeTxt.ReadOnly = true;
            this.imeTxt.Size = new System.Drawing.Size(213, 22);
            this.imeTxt.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 115;
            this.label5.Text = "Korisničko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Ime ";
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(12, 131);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(95, 41);
            this.nazadBtn.TabIndex = 136;
            this.nazadBtn.Text = "Početna";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // PregledIgracaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 194);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.korimeTxt);
            this.Controls.Add(this.prezimeTxt);
            this.Controls.Add(this.imeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "PregledIgracaForm";
            this.Text = "pregledIgracaForm";
            this.Load += new System.EventHandler(this.PregledIgracaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox korimeTxt;
        private System.Windows.Forms.TextBox prezimeTxt;
        private System.Windows.Forms.TextBox imeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nazadBtn;
    }
}