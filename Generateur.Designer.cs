
namespace PasswordCreatorAndTestor
{
    partial class Generateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generateur));
            this.lblAttributs = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblMotInclure = new System.Windows.Forms.Label();
            this.txtMotInclure = new System.Windows.Forms.TextBox();
            this.lblNbGen = new System.Windows.Forms.Label();
            this.txtNbGen = new System.Windows.Forms.TextBox();
            this.butGenerer = new System.Windows.Forms.Button();
            this.butEnrTexte = new System.Windows.Forms.Button();
            this.lstSpecs = new System.Windows.Forms.ListBox();
            this.butHaut = new System.Windows.Forms.Button();
            this.butBas = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.NumericUpDown();
            this.lstAttributs = new System.Windows.Forms.ListBox();
            this.butSupprimer = new System.Windows.Forms.Button();
            this.butMotInclure = new System.Windows.Forms.Button();
            this.lstMots = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.butGénérer = new System.Windows.Forms.Button();
            this.butListeMotsInclure = new System.Windows.Forms.Button();
            this.lblMaxCompteur = new System.Windows.Forms.Label();
            this.txtTexteGenere = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttributs
            // 
            this.lblAttributs.AutoEllipsis = true;
            this.lblAttributs.AutoSize = true;
            this.lblAttributs.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAttributs.Location = new System.Drawing.Point(64, 68);
            this.lblAttributs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttributs.Name = "lblAttributs";
            this.lblAttributs.Size = new System.Drawing.Size(83, 24);
            this.lblAttributs.TabIndex = 0;
            this.lblAttributs.Text = "Attributs";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoEllipsis = true;
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOptions.Location = new System.Drawing.Point(76, 399);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(77, 24);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Options";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaille.Location = new System.Drawing.Point(56, 128);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(119, 19);
            this.lblTaille.TabIndex = 3;
            this.lblTaille.Text = "Nb de caractères";
            // 
            // lblMotInclure
            // 
            this.lblMotInclure.AutoSize = true;
            this.lblMotInclure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotInclure.Location = new System.Drawing.Point(49, 310);
            this.lblMotInclure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotInclure.Name = "lblMotInclure";
            this.lblMotInclure.Size = new System.Drawing.Size(99, 19);
            this.lblMotInclure.TabIndex = 6;
            this.lblMotInclure.Text = "Mot à inclure ";
            // 
            // txtMotInclure
            // 
            this.txtMotInclure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotInclure.Location = new System.Drawing.Point(53, 348);
            this.txtMotInclure.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotInclure.Multiline = true;
            this.txtMotInclure.Name = "txtMotInclure";
            this.txtMotInclure.Size = new System.Drawing.Size(146, 28);
            this.txtMotInclure.TabIndex = 5;
            // 
            // lblNbGen
            // 
            this.lblNbGen.AutoSize = true;
            this.lblNbGen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbGen.Location = new System.Drawing.Point(48, 502);
            this.lblNbGen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbGen.Name = "lblNbGen";
            this.lblNbGen.Size = new System.Drawing.Size(126, 19);
            this.lblNbGen.TabIndex = 9;
            this.lblNbGen.Text = "Nombre à générer";
            // 
            // txtNbGen
            // 
            this.txtNbGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbGen.Location = new System.Drawing.Point(198, 502);
            this.txtNbGen.Margin = new System.Windows.Forms.Padding(2);
            this.txtNbGen.Name = "txtNbGen";
            this.txtNbGen.Size = new System.Drawing.Size(62, 26);
            this.txtNbGen.TabIndex = 8;
            this.txtNbGen.Text = "1";
            // 
            // butGenerer
            // 
            this.butGenerer.Location = new System.Drawing.Point(284, 495);
            this.butGenerer.Margin = new System.Windows.Forms.Padding(2);
            this.butGenerer.Name = "butGenerer";
            this.butGenerer.Size = new System.Drawing.Size(60, 37);
            this.butGenerer.TabIndex = 10;
            this.butGenerer.Text = "Générer";
            this.butGenerer.UseVisualStyleBackColor = true;
            this.butGenerer.Click += new System.EventHandler(this.butGenerer_Click);
            // 
            // butEnrTexte
            // 
            this.butEnrTexte.Location = new System.Drawing.Point(52, 439);
            this.butEnrTexte.Margin = new System.Windows.Forms.Padding(2);
            this.butEnrTexte.Name = "butEnrTexte";
            this.butEnrTexte.Size = new System.Drawing.Size(110, 37);
            this.butEnrTexte.TabIndex = 12;
            this.butEnrTexte.Text = "Enregistrer en texte";
            this.butEnrTexte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.butEnrTexte.UseVisualStyleBackColor = true;
            this.butEnrTexte.Click += new System.EventHandler(this.butEnrTexte_Click);
            // 
            // lstSpecs
            // 
            this.lstSpecs.FormattingEnabled = true;
            this.lstSpecs.Location = new System.Drawing.Point(388, 76);
            this.lstSpecs.Margin = new System.Windows.Forms.Padding(2);
            this.lstSpecs.Name = "lstSpecs";
            this.lstSpecs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSpecs.Size = new System.Drawing.Size(357, 472);
            this.lstSpecs.TabIndex = 13;
            // 
            // butHaut
            // 
            this.butHaut.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F);
            this.butHaut.Location = new System.Drawing.Point(752, 177);
            this.butHaut.Margin = new System.Windows.Forms.Padding(2);
            this.butHaut.Name = "butHaut";
            this.butHaut.Size = new System.Drawing.Size(38, 28);
            this.butHaut.TabIndex = 14;
            this.butHaut.Text = "";
            this.butHaut.UseVisualStyleBackColor = true;
            this.butHaut.Click += new System.EventHandler(this.butHaut_Click);
            // 
            // butBas
            // 
            this.butBas.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F);
            this.butBas.Location = new System.Drawing.Point(752, 216);
            this.butBas.Margin = new System.Windows.Forms.Padding(2);
            this.butBas.Name = "butBas";
            this.butBas.Size = new System.Drawing.Size(38, 28);
            this.butBas.TabIndex = 15;
            this.butBas.Text = "";
            this.butBas.UseVisualStyleBackColor = true;
            this.butBas.Click += new System.EventHandler(this.butBas_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(50, 565);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 16;
            // 
            // txtTaille
            // 
            this.txtTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaille.Location = new System.Drawing.Point(187, 128);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaille.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtTaille.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(50, 24);
            this.txtTaille.TabIndex = 17;
            this.txtTaille.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTaille.ValueChanged += new System.EventHandler(this.txtTaille_ValueChanged);
            // 
            // lstAttributs
            // 
            this.lstAttributs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAttributs.FormattingEnabled = true;
            this.lstAttributs.ItemHeight = 17;
            this.lstAttributs.Items.AddRange(new object[] {
            "Symbole",
            "Chiffre",
            "Lettre majuscule",
            "Lettre minuscule"});
            this.lstAttributs.Location = new System.Drawing.Point(60, 169);
            this.lstAttributs.Margin = new System.Windows.Forms.Padding(2);
            this.lstAttributs.Name = "lstAttributs";
            this.lstAttributs.Size = new System.Drawing.Size(138, 123);
            this.lstAttributs.TabIndex = 18;
            this.lstAttributs.SelectedIndexChanged += new System.EventHandler(this.lstAttributs_SelectedIndexChanged);
            this.lstAttributs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAttributs_KeyDown);
            // 
            // butSupprimer
            // 
            this.butSupprimer.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F);
            this.butSupprimer.Location = new System.Drawing.Point(752, 256);
            this.butSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.butSupprimer.Name = "butSupprimer";
            this.butSupprimer.Size = new System.Drawing.Size(38, 28);
            this.butSupprimer.TabIndex = 19;
            this.butSupprimer.Text = "";
            this.butSupprimer.UseVisualStyleBackColor = true;
            this.butSupprimer.Click += new System.EventHandler(this.butSupprimer_Click);
            // 
            // butMotInclure
            // 
            this.butMotInclure.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F);
            this.butMotInclure.Location = new System.Drawing.Point(208, 348);
            this.butMotInclure.Margin = new System.Windows.Forms.Padding(2);
            this.butMotInclure.Name = "butMotInclure";
            this.butMotInclure.Size = new System.Drawing.Size(38, 28);
            this.butMotInclure.TabIndex = 20;
            this.butMotInclure.Text = "";
            this.butMotInclure.UseVisualStyleBackColor = true;
            this.butMotInclure.Click += new System.EventHandler(this.butMotInclure_Click);
            // 
            // lstMots
            // 
            this.lstMots.FormattingEnabled = true;
            this.lstMots.Location = new System.Drawing.Point(268, 169);
            this.lstMots.Margin = new System.Windows.Forms.Padding(2);
            this.lstMots.Name = "lstMots";
            this.lstMots.Size = new System.Drawing.Size(112, 121);
            this.lstMots.TabIndex = 21;
            this.lstMots.SelectedIndexChanged += new System.EventHandler(this.lstMots_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(208, 169);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 26);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // butGénérer
            // 
            this.butGénérer.Location = new System.Drawing.Point(199, 203);
            this.butGénérer.Margin = new System.Windows.Forms.Padding(2);
            this.butGénérer.Name = "butGénérer";
            this.butGénérer.Size = new System.Drawing.Size(60, 19);
            this.butGénérer.TabIndex = 23;
            this.butGénérer.Text = "Générer";
            this.butGénérer.UseVisualStyleBackColor = true;
            this.butGénérer.Click += new System.EventHandler(this.butGénérer_Click);
            // 
            // butListeMotsInclure
            // 
            this.butListeMotsInclure.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F);
            this.butListeMotsInclure.Location = new System.Drawing.Point(301, 296);
            this.butListeMotsInclure.Margin = new System.Windows.Forms.Padding(2);
            this.butListeMotsInclure.Name = "butListeMotsInclure";
            this.butListeMotsInclure.Size = new System.Drawing.Size(38, 28);
            this.butListeMotsInclure.TabIndex = 24;
            this.butListeMotsInclure.Text = "";
            this.butListeMotsInclure.UseVisualStyleBackColor = true;
            this.butListeMotsInclure.Click += new System.EventHandler(this.butListeMotsInclure_Click);
            // 
            // lblMaxCompteur
            // 
            this.lblMaxCompteur.AutoSize = true;
            this.lblMaxCompteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCompteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMaxCompteur.Location = new System.Drawing.Point(276, 128);
            this.lblMaxCompteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxCompteur.Name = "lblMaxCompteur";
            this.lblMaxCompteur.Size = new System.Drawing.Size(29, 20);
            this.lblMaxCompteur.TabIndex = 25;
            this.lblMaxCompteur.Text = "10";
            // 
            // txtTexteGenere
            // 
            this.txtTexteGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexteGenere.Location = new System.Drawing.Point(804, 76);
            this.txtTexteGenere.Margin = new System.Windows.Forms.Padding(2);
            this.txtTexteGenere.Multiline = true;
            this.txtTexteGenere.Name = "txtTexteGenere";
            this.txtTexteGenere.ReadOnly = true;
            this.txtTexteGenere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexteGenere.Size = new System.Drawing.Size(355, 474);
            this.txtTexteGenere.TabIndex = 26;
            // 
            // Generateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 552);
            this.Controls.Add(this.txtTexteGenere);
            this.Controls.Add(this.lblMaxCompteur);
            this.Controls.Add(this.butListeMotsInclure);
            this.Controls.Add(this.butGénérer);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lstMots);
            this.Controls.Add(this.butMotInclure);
            this.Controls.Add(this.butSupprimer);
            this.Controls.Add(this.lstAttributs);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.butBas);
            this.Controls.Add(this.butHaut);
            this.Controls.Add(this.lstSpecs);
            this.Controls.Add(this.butEnrTexte);
            this.Controls.Add(this.butGenerer);
            this.Controls.Add(this.lblNbGen);
            this.Controls.Add(this.txtNbGen);
            this.Controls.Add(this.lblMotInclure);
            this.Controls.Add(this.txtMotInclure);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblAttributs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Generateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur";
            ((System.ComponentModel.ISupportInitialize)(this.txtTaille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttributs;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblMotInclure;
        private System.Windows.Forms.TextBox txtMotInclure;
        private System.Windows.Forms.Label lblNbGen;
        private System.Windows.Forms.TextBox txtNbGen;
        private System.Windows.Forms.Button butGenerer;
        private System.Windows.Forms.Button butEnrTexte;
        private System.Windows.Forms.ListBox lstSpecs;
        private System.Windows.Forms.Button butHaut;
        private System.Windows.Forms.Button butBas;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NumericUpDown txtTaille;
        private System.Windows.Forms.ListBox lstAttributs;
        private System.Windows.Forms.Button butSupprimer;
        private System.Windows.Forms.Button butMotInclure;
        private System.Windows.Forms.ListBox lstMots;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button butGénérer;
        private System.Windows.Forms.Button butListeMotsInclure;
        private System.Windows.Forms.Label lblMaxCompteur;
        private System.Windows.Forms.TextBox txtTexteGenere;
    }
}