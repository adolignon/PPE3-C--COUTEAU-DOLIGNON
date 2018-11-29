using System;

namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueModifSaison
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
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.cbSaison = new System.Windows.Forms.ComboBox();
            this.lblModif = new System.Windows.Forms.Label();
            this.lblSaison = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNbEp = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.bsSerie = new System.Windows.Forms.BindingSource(this.components);
            this.bsSaison = new System.Windows.Forms.BindingSource(this.components);
            this.nupAnnee = new System.Windows.Forms.NumericUpDown();
            this.nupNbEp = new System.Windows.Forms.NumericUpDown();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbEp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(265, 93);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(121, 21);
            this.cbSerie.TabIndex = 0;
            // 
            // cbSaison
            // 
            this.cbSaison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaison.FormattingEnabled = true;
            this.cbSaison.Location = new System.Drawing.Point(265, 141);
            this.cbSaison.Name = "cbSaison";
            this.cbSaison.Size = new System.Drawing.Size(121, 21);
            this.cbSaison.TabIndex = 1;
            // 
            // lblModif
            // 
            this.lblModif.AutoSize = true;
            this.lblModif.BackColor = System.Drawing.Color.Transparent;
            this.lblModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModif.ForeColor = System.Drawing.Color.White;
            this.lblModif.Location = new System.Drawing.Point(301, 33);
            this.lblModif.Name = "lblModif";
            this.lblModif.Size = new System.Drawing.Size(193, 24);
            this.lblModif.TabIndex = 2;
            this.lblModif.Text = "Modifier une saison";
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.BackColor = System.Drawing.Color.Transparent;
            this.lblSaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaison.ForeColor = System.Drawing.Color.White;
            this.lblSaison.Location = new System.Drawing.Point(12, 141);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(110, 24);
            this.lblSaison.TabIndex = 3;
            this.lblSaison.Text = "La saison :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "La série :";
            // 
            // lblNbEp
            // 
            this.lblNbEp.AutoSize = true;
            this.lblNbEp.BackColor = System.Drawing.Color.Transparent;
            this.lblNbEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbEp.ForeColor = System.Drawing.Color.White;
            this.lblNbEp.Location = new System.Drawing.Point(12, 241);
            this.lblNbEp.Name = "lblNbEp";
            this.lblNbEp.Size = new System.Drawing.Size(205, 24);
            this.lblNbEp.TabIndex = 5;
            this.lblNbEp.Text = "Nombre d\'épisodes :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.ForeColor = System.Drawing.Color.White;
            this.lblAnnee.Location = new System.Drawing.Point(12, 193);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(84, 24);
            this.lblAnnee.TabIndex = 6;
            this.lblAnnee.Text = "Année :";
            // 
            // bsSerie
            // 
            this.bsSerie.CurrentChanged += new System.EventHandler(this.bsSerie_CurrentChanged);
            // 
            // bsSaison
            // 
            this.bsSaison.CurrentChanged += new System.EventHandler(this.bsSaison_CurrentChanged);
            // 
            // nupAnnee
            // 
            this.nupAnnee.Location = new System.Drawing.Point(265, 193);
            this.nupAnnee.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nupAnnee.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.nupAnnee.Name = "nupAnnee";
            this.nupAnnee.Size = new System.Drawing.Size(120, 20);
            this.nupAnnee.TabIndex = 7;
            this.nupAnnee.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // nupNbEp
            // 
            this.nupNbEp.Location = new System.Drawing.Point(265, 241);
            this.nupNbEp.Name = "nupNbEp";
            this.nupNbEp.Size = new System.Drawing.Size(120, 20);
            this.nupNbEp.TabIndex = 8;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(185, 305);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(100, 34);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(583, 204);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(103, 39);
            this.btnRetour.TabIndex = 10;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // vueModifSaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.nupNbEp);
            this.Controls.Add(this.nupAnnee);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblNbEp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaison);
            this.Controls.Add(this.lblModif);
            this.Controls.Add(this.cbSaison);
            this.Controls.Add(this.cbSerie);
            this.Name = "vueModifSaison";
            this.Text = "Modifier une saison";
            ((System.ComponentModel.ISupportInitialize)(this.bsSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbEp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.ComboBox cbSaison;
        private System.Windows.Forms.Label lblModif;
        private System.Windows.Forms.Label lblSaison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNbEp;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.BindingSource bsSerie;
        private System.Windows.Forms.BindingSource bsSaison;
        private System.Windows.Forms.NumericUpDown nupAnnee;
        private System.Windows.Forms.NumericUpDown nupNbEp;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnRetour;
    }
}