namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueModifSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueModifSerie));
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbModif = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblRealisateur = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbRealisateur = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.bsGenre = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbResume = new System.Windows.Forms.TextBox();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.bsSerie = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(198, 133);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 0;
            // 
            // lbModif
            // 
            this.lbModif.AutoSize = true;
            this.lbModif.BackColor = System.Drawing.Color.Transparent;
            this.lbModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModif.ForeColor = System.Drawing.Color.White;
            this.lbModif.Location = new System.Drawing.Point(334, 23);
            this.lbModif.Name = "lbModif";
            this.lbModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbModif.Size = new System.Drawing.Size(179, 24);
            this.lbModif.TabIndex = 1;
            this.lbModif.Text = "Modifier une série";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BackColor = System.Drawing.Color.Transparent;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point(12, 340);
            this.lblImage.Name = "lblImage";
            this.lblImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImage.Size = new System.Drawing.Size(79, 24);
            this.lblImage.TabIndex = 2;
            this.lblImage.Text = "Image :";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.BackColor = System.Drawing.Color.Transparent;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.ForeColor = System.Drawing.Color.White;
            this.lblResume.Location = new System.Drawing.Point(12, 246);
            this.lblResume.Name = "lblResume";
            this.lblResume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResume.Size = new System.Drawing.Size(99, 24);
            this.lblResume.TabIndex = 3;
            this.lblResume.Text = "Résumé :";
            // 
            // lblRealisateur
            // 
            this.lblRealisateur.AutoSize = true;
            this.lblRealisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblRealisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealisateur.ForeColor = System.Drawing.Color.White;
            this.lblRealisateur.Location = new System.Drawing.Point(12, 207);
            this.lblRealisateur.Name = "lblRealisateur";
            this.lblRealisateur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRealisateur.Size = new System.Drawing.Size(126, 24);
            this.lblRealisateur.TabIndex = 4;
            this.lblRealisateur.Text = "Réalisateur :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(12, 171);
            this.lblNom.Name = "lblNom";
            this.lblNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNom.Size = new System.Drawing.Size(170, 24);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom de la série :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(12, 128);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGenre.Size = new System.Drawing.Size(80, 24);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(198, 171);
            this.tbNom.MaxLength = 150;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 7;
            // 
            // tbRealisateur
            // 
            this.tbRealisateur.Location = new System.Drawing.Point(198, 210);
            this.tbRealisateur.MaxLength = 60;
            this.tbRealisateur.Name = "tbRealisateur";
            this.tbRealisateur.Size = new System.Drawing.Size(100, 20);
            this.tbRealisateur.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(173, 340);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(353, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Modifier";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbResume
            // 
            this.tbResume.Location = new System.Drawing.Point(198, 244);
            this.tbResume.MaxLength = 150;
            this.tbResume.Multiline = true;
            this.tbResume.Name = "tbResume";
            this.tbResume.Size = new System.Drawing.Size(285, 69);
            this.tbResume.TabIndex = 15;
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(54, 72);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(109, 21);
            this.cbSerie.TabIndex = 16;
            // 
            // bsSerie
            // 
            this.bsSerie.CurrentChanged += new System.EventHandler(this.bsFilm_CurrentChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(599, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 39);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Retour";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // vueModifSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbSerie);
            this.Controls.Add(this.tbResume);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbRealisateur);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblRealisateur);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lbModif);
            this.Controls.Add(this.cbGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueModifSerie";
            this.Text = "Modifier une série";
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lbModif;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblRealisateur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbRealisateur;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.BindingSource bsGenre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbResume;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.BindingSource bsSerie;
        private System.Windows.Forms.Button btnClose;
    }
}