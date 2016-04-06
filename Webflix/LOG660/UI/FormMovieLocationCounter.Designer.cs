namespace LOG660.UI
{
    partial class FormMovieLocationCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lBoxAgeRange = new System.Windows.Forms.ListBox();
            this.lBoxProvince = new System.Windows.Forms.ListBox();
            this.lBoxDay = new System.Windows.Forms.ListBox();
            this.lBoxMonth = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Groupe d\'âge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mois";
            // 
            // lBoxAgeRange
            // 
            this.lBoxAgeRange.FormattingEnabled = true;
            this.lBoxAgeRange.ItemHeight = 16;
            this.lBoxAgeRange.Location = new System.Drawing.Point(53, 60);
            this.lBoxAgeRange.Name = "lBoxAgeRange";
            this.lBoxAgeRange.Size = new System.Drawing.Size(120, 84);
            this.lBoxAgeRange.TabIndex = 8;
            this.lBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // lBoxProvince
            // 
            this.lBoxProvince.FormattingEnabled = true;
            this.lBoxProvince.ItemHeight = 16;
            this.lBoxProvince.Location = new System.Drawing.Point(280, 60);
            this.lBoxProvince.Name = "lBoxProvince";
            this.lBoxProvince.Size = new System.Drawing.Size(120, 84);
            this.lBoxProvince.TabIndex = 15;
            this.lBoxProvince.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // lBoxDay
            // 
            this.lBoxDay.FormattingEnabled = true;
            this.lBoxDay.ItemHeight = 16;
            this.lBoxDay.Location = new System.Drawing.Point(53, 204);
            this.lBoxDay.Name = "lBoxDay";
            this.lBoxDay.Size = new System.Drawing.Size(120, 84);
            this.lBoxDay.TabIndex = 10;
            this.lBoxDay.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // lBoxMonth
            // 
            this.lBoxMonth.FormattingEnabled = true;
            this.lBoxMonth.ItemHeight = 16;
            this.lBoxMonth.Location = new System.Drawing.Point(280, 204);
            this.lBoxMonth.Name = "lBoxMonth";
            this.lBoxMonth.Size = new System.Drawing.Size(120, 84);
            this.lBoxMonth.TabIndex = 11;
            this.lBoxMonth.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre de locations effectuées";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtResults.Enabled = false;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(311, 383);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(47, 56);
            this.txtResults.TabIndex = 13;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "<-- Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMovieLocationCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lBoxMonth);
            this.Controls.Add(this.lBoxDay);
            this.Controls.Add(this.lBoxProvince);
            this.Controls.Add(this.lBoxAgeRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMovieLocationCounter";
            this.Text = "Compteur de locations de films";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lBoxAgeRange;
        private System.Windows.Forms.ListBox lBoxProvince;
        private System.Windows.Forms.ListBox lBoxDay;
        private System.Windows.Forms.ListBox lBoxMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button button1;
    }
}