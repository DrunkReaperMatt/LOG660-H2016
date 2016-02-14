namespace LOG660.UI
{
    partial class mainWindow
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtAllFieldSearch = new System.Windows.Forms.TextBox();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.btnUserMovies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(431, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // txtAllFieldSearch
            // 
            this.txtAllFieldSearch.Location = new System.Drawing.Point(12, 54);
            this.txtAllFieldSearch.Name = "txtAllFieldSearch";
            this.txtAllFieldSearch.Size = new System.Drawing.Size(375, 20);
            this.txtAllFieldSearch.TabIndex = 1;
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(400, 54);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(106, 23);
            this.btnAdvSearch.TabIndex = 2;
            this.btnAdvSearch.Text = "Advanced Search";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            // 
            // btnUserMovies
            // 
            this.btnUserMovies.Location = new System.Drawing.Point(12, 12);
            this.btnUserMovies.Name = "btnUserMovies";
            this.btnUserMovies.Size = new System.Drawing.Size(110, 23);
            this.btnUserMovies.TabIndex = 3;
            this.btnUserMovies.Text = "My rented movie(s)";
            this.btnUserMovies.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 304);
            this.Controls.Add(this.btnUserMovies);
            this.Controls.Add(this.btnAdvSearch);
            this.Controls.Add(this.txtAllFieldSearch);
            this.Controls.Add(this.btnLogout);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtAllFieldSearch;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.Button btnUserMovies;
    }
}