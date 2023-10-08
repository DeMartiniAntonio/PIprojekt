namespace Organiziranje_sportskog_događaja
{
    partial class PregledTimaForma
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
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clanoviTimaDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pocetnaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviTimaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(127, 37);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(191, 22);
            this.nazivTxt.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Naziv tima";
            // 
            // clanoviTimaDgv
            // 
            this.clanoviTimaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clanoviTimaDgv.Location = new System.Drawing.Point(16, 91);
            this.clanoviTimaDgv.Name = "clanoviTimaDgv";
            this.clanoviTimaDgv.RowHeadersWidth = 51;
            this.clanoviTimaDgv.RowTemplate.Height = 24;
            this.clanoviTimaDgv.Size = new System.Drawing.Size(302, 150);
            this.clanoviTimaDgv.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Članovi tima";
            // 
            // pocetnaBtn
            // 
            this.pocetnaBtn.Location = new System.Drawing.Point(16, 269);
            this.pocetnaBtn.Name = "pocetnaBtn";
            this.pocetnaBtn.Size = new System.Drawing.Size(84, 30);
            this.pocetnaBtn.TabIndex = 29;
            this.pocetnaBtn.Text = "Početna";
            this.pocetnaBtn.UseVisualStyleBackColor = true;
            this.pocetnaBtn.Click += new System.EventHandler(this.pocetnaBtn_Click);
            // 
            // PregledTimaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 326);
            this.Controls.Add(this.pocetnaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clanoviTimaDgv);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.label2);
            this.Name = "PregledTimaForma";
            this.Text = "PregledTimaForma";
            this.Load += new System.EventHandler(this.PregledTimaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clanoviTimaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView clanoviTimaDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pocetnaBtn;
    }
}