namespace LOG660.UI.Test
{
    partial class TestAdvancedSearch
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
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.pnlFilm = new System.Windows.Forms.Panel();
            this.txtFilm = new System.Windows.Forms.Label();
            this.pnlFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Location = new System.Drawing.Point(13, 13);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(112, 23);
            this.btnAdvancedSearch.TabIndex = 0;
            this.btnAdvancedSearch.Text = "Advanced Search";
            this.btnAdvancedSearch.UseVisualStyleBackColor = true;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.Location = new System.Drawing.Point(13, 43);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Size = new System.Drawing.Size(523, 46);
            this.pnlAdvanced.TabIndex = 1;
            // 
            // pnlFilm
            // 
            this.pnlFilm.Controls.Add(this.txtFilm);
            this.pnlFilm.Location = new System.Drawing.Point(12, 281);
            this.pnlFilm.Name = "pnlFilm";
            this.pnlFilm.Size = new System.Drawing.Size(523, 100);
            this.pnlFilm.TabIndex = 2;
            // 
            // txtFilm
            // 
            this.txtFilm.AutoSize = true;
            this.txtFilm.Location = new System.Drawing.Point(4, 4);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(54, 13);
            this.txtFilm.TabIndex = 0;
            this.txtFilm.Text = "Ouah Film";
            // 
            // TestAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 457);
            this.Controls.Add(this.pnlFilm);
            this.Controls.Add(this.pnlAdvanced);
            this.Controls.Add(this.btnAdvancedSearch);
            this.Name = "TestAdvancedSearch";
            this.Text = "TestAdvancedSearch";
            this.pnlFilm.ResumeLayout(false);
            this.pnlFilm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.Panel pnlFilm;
        private System.Windows.Forms.Label txtFilm;
    }
}