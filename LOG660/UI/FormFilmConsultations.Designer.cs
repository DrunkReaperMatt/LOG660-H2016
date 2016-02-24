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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_dataFilms = new System.Windows.Forms.DataGridView();
            this.m_lblFilms = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.m_dataActors = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.m_dataCountries = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblResume = new System.Windows.Forms.Label();
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
            this.m_lblBiographie = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.m_lblLieuNaissance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.m_lblDateNaissance = new System.Windows.Forms.Label();
            this.m_lblNomActeur = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fILMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_btnDeconnexion = new System.Windows.Forms.Button();
            this.m_btnLouerFilm = new System.Windows.Forms.Button();
            this.m_lblNomClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txtRecherche = new System.Windows.Forms.TextBox();
            this.m_btnOptionsRecherche = new System.Windows.Forms.Button();
            this.m_btnRechercher = new System.Windows.Forms.Button();
            this.m_btnEffacer = new System.Windows.Forms.Button();
            this.idScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPays = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.m_dataActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataCountries)).BeginInit();
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
            this.m_dataFilms.AllowUserToAddRows = false;
            this.m_dataFilms.AllowUserToDeleteRows = false;
            this.m_dataFilms.AllowUserToResizeColumns = false;
            this.m_dataFilms.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_dataFilms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.m_dataFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dataFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataFilms.ColumnHeadersVisible = false;
            this.m_dataFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.idFilm});
            this.m_dataFilms.Location = new System.Drawing.Point(3, 30);
            this.m_dataFilms.MultiSelect = false;
            this.m_dataFilms.Name = "m_dataFilms";
            this.m_dataFilms.ReadOnly = true;
            this.m_dataFilms.RowHeadersVisible = false;
            this.m_dataFilms.RowTemplate.Height = 28;
            this.m_dataFilms.Size = new System.Drawing.Size(251, 330);
            this.m_dataFilms.TabIndex = 11;
            this.m_dataFilms.SelectionChanged += new System.EventHandler(this.m_dataFilms_SelectionChanged);
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
            this.splitContainer2.Panel1.Controls.Add(this.m_dataActors);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel1.Controls.Add(this.m_dataCountries);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.m_lblResume);
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
            this.splitContainer2.Panel2.Controls.Add(this.m_lblBiographie);
            this.splitContainer2.Panel2.Controls.Add(this.label16);
            this.splitContainer2.Panel2.Controls.Add(this.m_lblLieuNaissance);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.m_lblDateNaissance);
            this.splitContainer2.Panel2.Controls.Add(this.m_lblNomActeur);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Size = new System.Drawing.Size(826, 366);
            this.splitContainer2.SplitterDistance = 252;
            this.splitContainer2.TabIndex = 0;
            // 
            // m_dataActors
            // 
            this.m_dataActors.AllowUserToAddRows = false;
            this.m_dataActors.AllowUserToDeleteRows = false;
            this.m_dataActors.AllowUserToResizeColumns = false;
            this.m_dataActors.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_dataActors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.m_dataActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dataActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataActors.ColumnHeadersVisible = false;
            this.m_dataActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActeur,
            this.Nom});
            this.m_dataActors.Location = new System.Drawing.Point(629, 77);
            this.m_dataActors.MultiSelect = false;
            this.m_dataActors.Name = "m_dataActors";
            this.m_dataActors.RowHeadersVisible = false;
            this.m_dataActors.Size = new System.Drawing.Size(189, 159);
            this.m_dataActors.TabIndex = 26;
            this.m_dataActors.SelectionChanged += new System.EventHandler(this.m_dataActors_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idScenariste,
            this.NomScenariste});
            this.dataGridView2.Location = new System.Drawing.Point(489, 77);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(134, 159);
            this.dataGridView2.TabIndex = 25;
            // 
            // m_dataCountries
            // 
            this.m_dataCountries.AllowUserToAddRows = false;
            this.m_dataCountries.AllowUserToDeleteRows = false;
            this.m_dataCountries.AllowUserToResizeColumns = false;
            this.m_dataCountries.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_dataCountries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.m_dataCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_dataCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataCountries.ColumnHeadersVisible = false;
            this.m_dataCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPays,
            this.NomPays});
            this.m_dataCountries.Enabled = false;
            this.m_dataCountries.Location = new System.Drawing.Point(345, 77);
            this.m_dataCountries.MultiSelect = false;
            this.m_dataCountries.Name = "m_dataCountries";
            this.m_dataCountries.ReadOnly = true;
            this.m_dataCountries.RowHeadersVisible = false;
            this.m_dataCountries.Size = new System.Drawing.Size(138, 159);
            this.m_dataCountries.TabIndex = 12;
            this.m_dataCountries.SelectionChanged += new System.EventHandler(this.m_dataCountries_SelectionChanged);
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
            // m_lblResume
            // 
            this.m_lblResume.AutoSize = true;
            this.m_lblResume.Location = new System.Drawing.Point(141, 147);
            this.m_lblResume.MaximumSize = new System.Drawing.Size(200, 200);
            this.m_lblResume.Name = "m_lblResume";
            this.m_lblResume.Size = new System.Drawing.Size(197, 26);
            this.m_lblResume.TabIndex = 21;
            this.m_lblResume.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
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
            // m_lblBiographie
            // 
            this.m_lblBiographie.AutoSize = true;
            this.m_lblBiographie.Location = new System.Drawing.Point(468, 50);
            this.m_lblBiographie.Name = "m_lblBiographie";
            this.m_lblBiographie.Size = new System.Drawing.Size(62, 13);
            this.m_lblBiographie.TabIndex = 30;
            this.m_lblBiographie.Text = "[biographie]";
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
            // m_lblLieuNaissance
            // 
            this.m_lblLieuNaissance.AutoSize = true;
            this.m_lblLieuNaissance.Location = new System.Drawing.Point(141, 73);
            this.m_lblLieuNaissance.Name = "m_lblLieuNaissance";
            this.m_lblLieuNaissance.Size = new System.Drawing.Size(79, 13);
            this.m_lblLieuNaissance.TabIndex = 28;
            this.m_lblLieuNaissance.Text = "[lieuNaissance]";
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
            // m_lblDateNaissance
            // 
            this.m_lblDateNaissance.AutoSize = true;
            this.m_lblDateNaissance.Location = new System.Drawing.Point(141, 50);
            this.m_lblDateNaissance.Name = "m_lblDateNaissance";
            this.m_lblDateNaissance.Size = new System.Drawing.Size(84, 13);
            this.m_lblDateNaissance.TabIndex = 26;
            this.m_lblDateNaissance.Text = "[dateNaissance]";
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
            this.m_btnDeconnexion.Click += new System.EventHandler(this.m_btnDeconnexion_Click);
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
            // idScenariste
            // 
            this.idScenariste.HeaderText = "idScenariste";
            this.idScenariste.Name = "idScenariste";
            this.idScenariste.ReadOnly = true;
            this.idScenariste.Visible = false;
            // 
            // NomScenariste
            // 
            this.NomScenariste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NomScenariste.HeaderText = "NomScenariste";
            this.NomScenariste.Name = "NomScenariste";
            this.NomScenariste.ReadOnly = true;
            this.NomScenariste.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomScenariste.Width = 5;
            // 
            // idActeur
            // 
            this.idActeur.HeaderText = "idActeur";
            this.idActeur.Name = "idActeur";
            this.idActeur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idActeur.Visible = false;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Titre
            // 
            this.Titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.DefaultCellStyle = dataGridViewCellStyle6;
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            this.Titre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idFilm
            // 
            this.idFilm.HeaderText = "idFilm";
            this.idFilm.Name = "idFilm";
            this.idFilm.ReadOnly = true;
            this.idFilm.Visible = false;
            // 
            // idPays
            // 
            this.idPays.HeaderText = "idPays";
            this.idPays.Name = "idPays";
            this.idPays.ReadOnly = true;
            this.idPays.Visible = false;
            // 
            // NomPays
            // 
            this.NomPays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomPays.HeaderText = "NomPays";
            this.NomPays.Name = "NomPays";
            this.NomPays.ReadOnly = true;
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
            this.Load += new System.EventHandler(this.FormFilmConsultations_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.m_dataActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataCountries)).EndInit();
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
        private System.Windows.Forms.Label m_lblResume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblBiographie;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label m_lblLieuNaissance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label m_lblDateNaissance;
        private System.Windows.Forms.Label m_lblNomActeur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView m_dataActors;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView m_dataCountries;
        private System.Windows.Forms.BindingSource fILMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPays;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPays;
    }
}