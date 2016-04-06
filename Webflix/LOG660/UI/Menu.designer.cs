namespace LOG660.UI
{
    partial class Menu
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
            this.btnConsultMovie = new System.Windows.Forms.Button();
            this.btnMovieCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultMovie
            // 
            this.btnConsultMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultMovie.Location = new System.Drawing.Point(65, 13);
            this.btnConsultMovie.Name = "btnConsultMovie";
            this.btnConsultMovie.Size = new System.Drawing.Size(149, 86);
            this.btnConsultMovie.TabIndex = 0;
            this.btnConsultMovie.Text = "Consultation/Recherche de film";
            this.btnConsultMovie.UseVisualStyleBackColor = true;
            this.btnConsultMovie.Click += new System.EventHandler(this.btnConsultMovie_Click);
            // 
            // btnMovieCounter
            // 
            this.btnMovieCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieCounter.Location = new System.Drawing.Point(65, 115);
            this.btnMovieCounter.Name = "btnMovieCounter";
            this.btnMovieCounter.Size = new System.Drawing.Size(149, 103);
            this.btnMovieCounter.TabIndex = 1;
            this.btnMovieCounter.Text = "Analyse des locations";
            this.btnMovieCounter.UseVisualStyleBackColor = true;
            this.btnMovieCounter.Click += new System.EventHandler(this.btnMovieCounter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 230);
            this.Controls.Add(this.btnMovieCounter);
            this.Controls.Add(this.btnConsultMovie);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultMovie;
        private System.Windows.Forms.Button btnMovieCounter;
    }
}