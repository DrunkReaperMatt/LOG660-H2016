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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilm = new System.Windows.Forms.Label();
            this.m_btnLouerFilm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.pnlAdvanced.Size = new System.Drawing.Size(523, 15);
            this.pnlAdvanced.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFilm);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 352);
            this.panel1.TabIndex = 2;
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
            // m_btnLouerFilm
            // 
            this.m_btnLouerFilm.Location = new System.Drawing.Point(498, 422);
            this.m_btnLouerFilm.Name = "m_btnLouerFilm";
            this.m_btnLouerFilm.Size = new System.Drawing.Size(75, 23);
            this.m_btnLouerFilm.TabIndex = 3;
            this.m_btnLouerFilm.Text = "button1";
            this.m_btnLouerFilm.UseVisualStyleBackColor = true;
            // 
            // TestAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(585, 457);
            this.Controls.Add(this.m_btnLouerFilm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdvanced);
            this.Controls.Add(this.btnAdvancedSearch);
            this.Name = "TestAdvancedSearch";
            this.Text = "TestAdvancedSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtFilm;
        private System.Windows.Forms.Button m_btnLouerFilm;
    }
}