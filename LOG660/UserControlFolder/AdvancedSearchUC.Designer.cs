namespace LOG660.UserControlFolder
{
    partial class AdvancedSearchUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.btnAddField = new System.Windows.Forms.Button();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.pnlUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(147, 3);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(241, 20);
            this.txtSearchText.TabIndex = 0;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Années",
            "Pays",
            "Langue",
            "Genres",
            "Réalisateur",
            "Acteur"});
            this.cboField.Location = new System.Drawing.Point(3, 3);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(138, 21);
            this.cboField.TabIndex = 1;
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(394, 3);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(37, 23);
            this.btnAddField.TabIndex = 2;
            this.btnAddField.Text = "+";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // pnlUC
            // 
            this.pnlUC.Controls.Add(this.cboField);
            this.pnlUC.Controls.Add(this.btnAddField);
            this.pnlUC.Controls.Add(this.txtSearchText);
            this.pnlUC.Location = new System.Drawing.Point(3, 3);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(437, 30);
            this.pnlUC.TabIndex = 3;
            // 
            // AdvancedSearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUC);
            this.Name = "AdvancedSearchUC";
            this.Size = new System.Drawing.Size(443, 36);
            this.pnlUC.ResumeLayout(false);
            this.pnlUC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Panel pnlUC;
    }
}
