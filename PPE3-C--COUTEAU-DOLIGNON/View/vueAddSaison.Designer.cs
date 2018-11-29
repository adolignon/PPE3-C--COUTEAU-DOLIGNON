using System;

namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueAddSaison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueAddSaison));
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bsSerie = new System.Windows.Forms.BindingSource(this.components);
            this.nupAnnee = new System.Windows.Forms.NumericUpDown();
            this.nupNbEp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bsSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbEp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(54, 85);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(150, 21);
            this.cbSerie.TabIndex = 0;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(308, 19);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(191, 24);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "Ajouter une saison ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre d\'episodes :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.ForeColor = System.Drawing.Color.White;
            this.lblAnnee.Location = new System.Drawing.Point(12, 157);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(84, 24);
            this.lblAnnee.TabIndex = 5;
            this.lblAnnee.Text = "Année :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter la saison";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(523, 178);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(96, 41);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Retour";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // nupAnnee
            // 
            this.nupAnnee.Location = new System.Drawing.Point(240, 157);
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
            this.nupAnnee.TabIndex = 8;
            this.nupAnnee.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // nupNbEp
            // 
            this.nupNbEp.Location = new System.Drawing.Point(240, 211);
            this.nupNbEp.Name = "nupNbEp";
            this.nupNbEp.Size = new System.Drawing.Size(120, 20);
            this.nupNbEp.TabIndex = 9;
            // 
            // vueAddSaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nupNbEp);
            this.Controls.Add(this.nupAnnee);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.cbSerie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueAddSaison";
            this.Text = "Ajouter une saison";
            ((System.ComponentModel.ISupportInitialize)(this.bsSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbEp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.BindingSource bsSerie;
        private System.Windows.Forms.NumericUpDown nupAnnee;
        private System.Windows.Forms.NumericUpDown nupNbEp;
    }
}