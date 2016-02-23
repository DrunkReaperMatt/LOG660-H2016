namespace LOG660.UI
{
    partial class FormFilmConsultations
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_dataFilms = new System.Windows.Forms.DataGridView();
            this.m_lblFilms = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_lblRealisateur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_lblDuree = new System.Windows.Forms.Label();
            this.m_titleDuree = new System.Windows.Forms.Label();
            this.m_lblLangue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_lblAnnee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lblTitreFilm = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.m_lblNomA = new System.Windows.Forms.Label();
            this.m_lblNomActeur = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.m_btnDeconnexion = new System.Windows.Forms.Button();
            this.m_btnLouerFilm = new System.Windows.Forms.Button();
            this.m_lblNomClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txtRecherche = new System.Windows.Forms.TextBox();
            this.m_btnOptionsRecherche = new System.Windows.Forms.Button();
            this.m_btnRechercher = new System.Windows.Forms.Button();
            this.m_btnEffacer = new System.Windows.Forms.Button();
            this.fILMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(26, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 366);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "";
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.Panel1.Controls.Add(this.m_dataFilms);
            this.splitContainer1.Panel1.Controls.Add(this.m_lblFilms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 366);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // m_dataFilms
            // 
            this.m_dataFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dataFilms.AutoGenerateColumns = false;
            this.m_dataFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataFilms.DataSource = this.fILMBindingSource;
            this.m_dataFilms.Location = new System.Drawing.Point(3, 30);
            this.m_dataFilms.Name = "m_dataFilms";
            this.m_dataFilms.Size = new System.Drawing.Size(251, 330);
            this.m_dataFilms.TabIndex = 11;
            // 
            // m_lblFilms
            // 
            this.m_lblFilms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_lblFilms.AutoSize = true;
            this.m_lblFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblFilms.Location = new System.Drawing.Point(109, 10);
            this.m_lblFilms.Name = "m_lblFilms";
            this.m_lblFilms.Size = new System.Drawing.Size(45, 17);
            this.m_lblFilms.TabIndex = 10;
            this.m_lblFilms.Text = "Films";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView3);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.m_lblRealisateur);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.m_lblDuree);
            this.splitContainer2.Panel1.Controls.Add(this.m_titleDuree);
            this.splitContainer2.Panel1.Controls.Add(this.m_lblLangue);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.m_lblAnnee);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.m_lblTitreFilm);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label15);
            this.splitContainer2.Panel2.Controls.Add(this.label16);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.m_lblNomA);
            this.splitContainer2.Panel2.Controls.Add(this.m_lblNomActeur);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Size = new System.Drawing.Size(826, 366);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(629, 77);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(189, 160);
            this.dataGridView3.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(489, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(134, 160);
            this.dataGridView2.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(138, 160);
            this.dataGridView1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Acteurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Scénaristes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pays de production";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 147);
            this.label7.MaximumSize = new System.Drawing.Size(200, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Résumé:";
            // 
            // m_lblRealisateur
            // 
            this.m_lblRealisateur.AutoSize = true;
            this.m_lblRealisateur.Location = new System.Drawing.Point(141, 125);
            this.m_lblRealisateur.Name = "m_lblRealisateur";
            this.m_lblRealisateur.Size = new System.Drawing.Size(61, 13);
            this.m_lblRealisateur.TabIndex = 19;
            this.m_lblRealisateur.Text = "[realisateur]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Réalisateur:";
            // 
            // m_lblDuree
            // 
            this.m_lblDuree.AutoSize = true;
            this.m_lblDuree.Location = new System.Drawing.Point(141, 100);
            this.m_lblDuree.Name = "m_lblDuree";
            this.m_lblDuree.Size = new System.Drawing.Size(40, 13);
            this.m_lblDuree.TabIndex = 17;
            this.m_lblDuree.Text = "[duree]";
            // 
            // m_titleDuree
            // 
            this.m_titleDuree.AutoSize = true;
            this.m_titleDuree.Location = new System.Drawing.Point(54, 100);
            this.m_titleDuree.Name = "m_titleDuree";
            this.m_titleDuree.Size = new System.Drawing.Size(84, 13);
            this.m_titleDuree.TabIndex = 16;
            this.m_titleDuree.Text = "Durée (minutes):";
            // 
            // m_lblLangue
            // 
            this.m_lblLangue.AutoSize = true;
            this.m_lblLangue.Location = new System.Drawing.Point(141, 77);
            this.m_lblLangue.Name = "m_lblLangue";
            this.m_lblLangue.Size = new System.Drawing.Size(45, 13);
            this.m_lblLangue.TabIndex = 15;
            this.m_lblLangue.Text = "[langue]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Langue originale:";
            // 
            // m_lblAnnee
            // 
            this.m_lblAnnee.AutoSize = true;
            this.m_lblAnnee.Location = new System.Drawing.Point(141, 55);
            this.m_lblAnnee.Name = "m_lblAnnee";
            this.m_lblAnnee.Size = new System.Drawing.Size(43, 13);
            this.m_lblAnnee.TabIndex = 13;
            this.m_lblAnnee.Text = "[annee]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Année de sortie:";
            // 
            // m_lblTitreFilm
            // 
            this.m_lblTitreFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_lblTitreFilm.AutoSize = true;
            this.m_lblTitreFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblTitreFilm.Location = new System.Drawing.Point(376, 10);
            this.m_lblTitreFilm.Name = "m_lblTitreFilm";
            this.m_lblTitreFilm.Size = new System.Drawing.Size(76, 17);
            this.m_lblTitreFilm.TabIndex = 12;
            this.m_lblTitreFilm.Text = "Titre Film";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(468, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "[biographie]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(402, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Biographie:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "[lieuNaissance]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Lieu naissance:";
            // 
            // m_lblNomA
            // 
            this.m_lblNomA.AutoSize = true;
            this.m_lblNomA.Location = new System.Drawing.Point(141, 50);
            this.m_lblNomA.Name = "m_lblNomA";
            this.m_lblNomA.Size = new System.Drawing.Size(84, 13);
            this.m_lblNomA.TabIndex = 26;
            this.m_lblNomA.Text = "[dateNaissance]";
            // 
            // m_lblNomActeur
            // 
            this.m_lblNomActeur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_lblNomActeur.AutoSize = true;
            this.m_lblNomActeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblNomActeur.Location = new System.Drawing.Point(388, 10);
            this.m_lblNomActeur.Name = "m_lblNomActeur";
            this.m_lblNomActeur.Size = new System.Drawing.Size(55, 17);
            this.m_lblNomActeur.TabIndex = 25;
            this.m_lblNomActeur.Text = "Acteur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Date Naissance:";
            // 
            // m_btnDeconnexion
            // 
            this.m_btnDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnDeconnexion.Location = new System.Drawing.Point(1024, 35);
            this.m_btnDeconnexion.Name = "m_btnDeconnexion";
            this.m_btnDeconnexion.Size = new System.Drawing.Size(89, 23);
            this.m_btnDeconnexion.TabIndex = 1;
            this.m_btnDeconnexion.Text = "Déconnexion";
            this.m_btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // m_btnLouerFilm
            // 
            this.m_btnLouerFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnLouerFilm.Location = new System.Drawing.Point(1024, 436);
            this.m_btnLouerFilm.Name = "m_btnLouerFilm";
            this.m_btnLouerFilm.Size = new System.Drawing.Size(89, 23);
            this.m_btnLouerFilm.TabIndex = 2;
            this.m_btnLouerFilm.Text = "Louer film";
            this.m_btnLouerFilm.UseVisualStyleBackColor = true;
            this.m_btnLouerFilm.Click += new System.EventHandler(this.m_btnLouerFilm_Click);
            // 
            // m_lblNomClient
            // 
            this.m_lblNomClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_lblNomClient.AutoSize = true;
            this.m_lblNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblNomClient.Location = new System.Drawing.Point(542, 14);
            this.m_lblNomClient.Name = "m_lblNomClient";
            this.m_lblNomClient.Size = new System.Drawing.Size(96, 20);
            this.m_lblNomClient.TabIndex = 3;
            this.m_lblNomClient.Text = "Nom Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rechercher:";
            // 
            // m_txtRecherche
            // 
            this.m_txtRecherche.Location = new System.Drawing.Point(89, 37);
            this.m_txtRecherche.Name = "m_txtRecherche";
            this.m_txtRecherche.Size = new System.Drawing.Size(139, 20);
            this.m_txtRecherche.TabIndex = 5;
            // 
            // m_btnOptionsRecherche
            // 
            this.m_btnOptionsRecherche.Location = new System.Drawing.Point(330, 35);
            this.m_btnOptionsRecherche.Name = "m_btnOptionsRecherche";
            this.m_btnOptionsRecherche.Size = new System.Drawing.Size(119, 23);
            this.m_btnOptionsRecherche.TabIndex = 7;
            this.m_btnOptionsRecherche.Text = "Recherche avancée";
            this.m_btnOptionsRecherche.UseVisualStyleBackColor = true;
            // 
            // m_btnRechercher
            // 
            this.m_btnRechercher.Location = new System.Drawing.Point(234, 35);
            this.m_btnRechercher.Name = "m_btnRechercher";
            this.m_btnRechercher.Size = new System.Drawing.Size(35, 23);
            this.m_btnRechercher.TabIndex = 8;
            this.m_btnRechercher.Text = "Go";
            this.m_btnRechercher.UseVisualStyleBackColor = true;
            this.m_btnRechercher.Click += new System.EventHandler(this.m_btnRechercher_Click);
            // 
            // m_btnEffacer
            // 
            this.m_btnEffacer.Location = new System.Drawing.Point(275, 35);
            this.m_btnEffacer.Name = "m_btnEffacer";
            this.m_btnEffacer.Size = new System.Drawing.Size(49, 23);
            this.m_btnEffacer.TabIndex = 9;
            this.m_btnEffacer.Text = "Effacer";
            this.m_btnEffacer.UseVisualStyleBackColor = true;
            this.m_btnEffacer.Click += new System.EventHandler(this.m_btnEffacer_Click);
            // 
            // FormFilmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 462);
            this.Controls.Add(this.m_btnEffacer);
            this.Controls.Add(this.m_btnRechercher);
            this.Controls.Add(this.m_btnOptionsRecherche);
            this.Controls.Add(this.m_txtRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lblNomClient);
            this.Controls.Add(this.m_btnLouerFilm);
            this.Controls.Add(this.m_btnDeconnexion);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "FormFilmConsultations";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFilmConsultations_FormClosed);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataFilms)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button m_btnDeconnexion;
        private System.Windows.Forms.Button m_btnLouerFilm;
        private System.Windows.Forms.Label m_lblNomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txtRecherche;
        private System.Windows.Forms.Button m_btnOptionsRecherche;
        private System.Windows.Forms.Button m_btnRechercher;
        private System.Windows.Forms.Button m_btnEffacer;
        private System.Windows.Forms.DataGridView m_dataFilms;
        private System.Windows.Forms.Label m_lblFilms;
        private System.Windows.Forms.Label m_lblRealisateur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_lblDuree;
        private System.Windows.Forms.Label m_titleDuree;
        private System.Windows.Forms.Label m_lblLangue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_lblAnnee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_lblTitreFilm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label m_lblNomA;
        private System.Windows.Forms.Label m_lblNomActeur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fILMBindingSource;
    }
}