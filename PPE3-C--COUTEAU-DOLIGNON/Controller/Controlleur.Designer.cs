namespace PPE3_C__COUTEAU_DOLIGNON
{
    partial class Controlleur
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controlleur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recherchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSUpportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parReferenceEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDateAbonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validationDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vérificationDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermetureDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.recherchesToolStripMenuItem,
            this.comptesToolStripMenuItem,
            this.composantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // recherchesToolStripMenuItem
            // 
            this.recherchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parGenreToolStripMenuItem,
            this.parSUpportToolStripMenuItem,
            this.parClientToolStripMenuItem,
            this.parReferenceEmpruntToolStripMenuItem,
            this.parDateAbonnementToolStripMenuItem});
            this.recherchesToolStripMenuItem.Name = "recherchesToolStripMenuItem";
            this.recherchesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.recherchesToolStripMenuItem.Text = "Recherches";
            // 
            // parGenreToolStripMenuItem
            // 
            this.parGenreToolStripMenuItem.Name = "parGenreToolStripMenuItem";
            this.parGenreToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parGenreToolStripMenuItem.Text = "Par Genre";
            this.parGenreToolStripMenuItem.Click += new System.EventHandler(this.parGenreToolStripMenuItem_Click);
            // 
            // parSUpportToolStripMenuItem
            // 
            this.parSUpportToolStripMenuItem.Name = "parSUpportToolStripMenuItem";
            this.parSUpportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parSUpportToolStripMenuItem.Text = "Par Support";
            this.parSUpportToolStripMenuItem.Click += new System.EventHandler(this.parSUpportToolStripMenuItem_Click);
            // 
            // parClientToolStripMenuItem
            // 
            this.parClientToolStripMenuItem.Name = "parClientToolStripMenuItem";
            this.parClientToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parClientToolStripMenuItem.Text = "Par Client";
            this.parClientToolStripMenuItem.Click += new System.EventHandler(this.parClientToolStripMenuItem_Click);
            // 
            // parReferenceEmpruntToolStripMenuItem
            // 
            this.parReferenceEmpruntToolStripMenuItem.Name = "parReferenceEmpruntToolStripMenuItem";
            this.parReferenceEmpruntToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parReferenceEmpruntToolStripMenuItem.Text = "Par Reference Emprunt";
            this.parReferenceEmpruntToolStripMenuItem.Click += new System.EventHandler(this.parReferenceEmpruntToolStripMenuItem_Click);
            // 
            // parDateAbonnementToolStripMenuItem
            // 
            this.parDateAbonnementToolStripMenuItem.Name = "parDateAbonnementToolStripMenuItem";
            this.parDateAbonnementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parDateAbonnementToolStripMenuItem.Text = "Par Date Abonnement";
            this.parDateAbonnementToolStripMenuItem.Click += new System.EventHandler(this.parDateAbonnementToolStripMenuItem_Click);
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validationDunCompteToolStripMenuItem,
            this.vérificationDunCompteToolStripMenuItem,
            this.fermetureDunCompteToolStripMenuItem,
            this.ajoutDunCompteToolStripMenuItem});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // validationDunCompteToolStripMenuItem
            // 
            this.validationDunCompteToolStripMenuItem.Name = "validationDunCompteToolStripMenuItem";
            this.validationDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.validationDunCompteToolStripMenuItem.Text = "Validation d\'un compte";
            this.validationDunCompteToolStripMenuItem.Click += new System.EventHandler(this.validationDunCompteToolStripMenuItem_Click);
            // 
            // vérificationDunCompteToolStripMenuItem
            // 
            this.vérificationDunCompteToolStripMenuItem.Name = "vérificationDunCompteToolStripMenuItem";
            this.vérificationDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.vérificationDunCompteToolStripMenuItem.Text = "Vérification d\'un compte";
            this.vérificationDunCompteToolStripMenuItem.Click += new System.EventHandler(this.vérificationDunCompteToolStripMenuItem_Click);
            // 
            // fermetureDunCompteToolStripMenuItem
            // 
            this.fermetureDunCompteToolStripMenuItem.Name = "fermetureDunCompteToolStripMenuItem";
            this.fermetureDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fermetureDunCompteToolStripMenuItem.Text = "Fermeture d\'un compte";
            this.fermetureDunCompteToolStripMenuItem.Click += new System.EventHandler(this.fermetureDunCompteToolStripMenuItem_Click);
            // 
            // ajoutDunCompteToolStripMenuItem
            // 
            this.ajoutDunCompteToolStripMenuItem.Name = "ajoutDunCompteToolStripMenuItem";
            this.ajoutDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ajoutDunCompteToolStripMenuItem.Text = "Ajout d\'un compte";
            // 
            // composantsToolStripMenuItem
            // 
            this.composantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.sérieToolStripMenuItem,
            this.saisonToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.composantsToolStripMenuItem.Name = "composantsToolStripMenuItem";
            this.composantsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.composantsToolStripMenuItem.Text = "Composants";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem1,
            this.modificationToolStripMenuItem1});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // ajoutToolStripMenuItem1
            // 
            this.ajoutToolStripMenuItem1.Name = "ajoutToolStripMenuItem1";
            this.ajoutToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem1.Text = "Ajout";
            this.ajoutToolStripMenuItem1.Click += new System.EventHandler(this.ajoutToolStripMenuItem1_Click);
            // 
            // modificationToolStripMenuItem1
            // 
            this.modificationToolStripMenuItem1.Name = "modificationToolStripMenuItem1";
            this.modificationToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem1.Text = "Modification";
            // 
            // sérieToolStripMenuItem
            // 
            this.sérieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem2,
            this.modificationToolStripMenuItem2});
            this.sérieToolStripMenuItem.Name = "sérieToolStripMenuItem";
            this.sérieToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sérieToolStripMenuItem.Text = "Série";
            // 
            // ajoutToolStripMenuItem2
            // 
            this.ajoutToolStripMenuItem2.Name = "ajoutToolStripMenuItem2";
            this.ajoutToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem2.Text = "Ajout";
            // 
            // modificationToolStripMenuItem2
            // 
            this.modificationToolStripMenuItem2.Name = "modificationToolStripMenuItem2";
            this.modificationToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem2.Text = "Modification";
            // 
            // saisonToolStripMenuItem
            // 
            this.saisonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem3,
            this.modificationToolStripMenuItem3});
            this.saisonToolStripMenuItem.Name = "saisonToolStripMenuItem";
            this.saisonToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saisonToolStripMenuItem.Text = "Saison";
            // 
            // ajoutToolStripMenuItem3
            // 
            this.ajoutToolStripMenuItem3.Name = "ajoutToolStripMenuItem3";
            this.ajoutToolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem3.Text = "Ajout";
            // 
            // modificationToolStripMenuItem3
            // 
            this.modificationToolStripMenuItem3.Name = "modificationToolStripMenuItem3";
            this.modificationToolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem3.Text = "Modification";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem4,
            this.modificationToolStripMenuItem4});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajoutToolStripMenuItem4
            // 
            this.ajoutToolStripMenuItem4.Name = "ajoutToolStripMenuItem4";
            this.ajoutToolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem4.Text = "Ajout";
            // 
            // modificationToolStripMenuItem4
            // 
            this.modificationToolStripMenuItem4.Name = "modificationToolStripMenuItem4";
            this.modificationToolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem4.Text = "Modification";
            // 
            // Controlleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 487);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Controlleur";
            this.Text = "Video&CO Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recherchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSUpportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parReferenceEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDateAbonnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validationDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vérificationDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermetureDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem4;
    }
}

