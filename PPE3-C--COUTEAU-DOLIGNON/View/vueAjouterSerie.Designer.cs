namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueAjouterSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueAjouterSerie));
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblRealisateur = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.bsGenre = new System.Windows.Forms.BindingSource(this.components);
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbResume = new System.Windows.Forms.TextBox();
            this.tbRealisateur = new System.Windows.Forms.TextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(305, 28);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(171, 24);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Ajouter une série";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.BackColor = System.Drawing.Color.Transparent;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.ForeColor = System.Drawing.Color.White;
            this.lblResume.Location = new System.Drawing.Point(12, 211);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(99, 24);
            this.lblResume.TabIndex = 1;
            this.lblResume.Text = "Resume :";
            // 
            // lblRealisateur
            // 
            this.lblRealisateur.AutoSize = true;
            this.lblRealisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblRealisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealisateur.ForeColor = System.Drawing.Color.White;
            this.lblRealisateur.Location = new System.Drawing.Point(12, 169);
            this.lblRealisateur.Name = "lblRealisateur";
            this.lblRealisateur.Size = new System.Drawing.Size(126, 24);
            this.lblRealisateur.TabIndex = 2;
            this.lblRealisateur.Text = "Réalisateur :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(12, 124);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(66, 24);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(12, 83);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(80, 24);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre :";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BackColor = System.Drawing.Color.Transparent;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point(12, 312);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(79, 24);
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "Image :";
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(158, 86);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 6;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(158, 127);
            this.tbNom.MaxLength = 150;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 7;
            // 
            // tbResume
            // 
            this.tbResume.Location = new System.Drawing.Point(158, 211);
            this.tbResume.MaxLength = 150;
            this.tbResume.Multiline = true;
            this.tbResume.Name = "tbResume";
            this.tbResume.Size = new System.Drawing.Size(329, 83);
            this.tbResume.TabIndex = 8;
            // 
            // tbRealisateur
            // 
            this.tbRealisateur.Location = new System.Drawing.Point(158, 169);
            this.tbRealisateur.MaxLength = 60;
            this.tbRealisateur.Name = "tbRealisateur";
            this.tbRealisateur.Size = new System.Drawing.Size(100, 20);
            this.tbRealisateur.TabIndex = 9;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(158, 312);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "Upload";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(365, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(600, 189);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(92, 38);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // vueAjouterSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.tbRealisateur);
            this.Controls.Add(this.tbResume);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblRealisateur);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.lblAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueAjouterSerie";
            this.Text = "Ajouter une série";
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblRealisateur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.BindingSource bsGenre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbResume;
        private System.Windows.Forms.TextBox tbRealisateur;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetour;
    }
}