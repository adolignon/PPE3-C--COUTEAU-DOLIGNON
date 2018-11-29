namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueValidationCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueValidationCompte));
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.btnValidCompte = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.bsClients = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClients
            // 
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(284, 167);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(259, 21);
            this.cbClients.TabIndex = 0;
            // 
            // btnValidCompte
            // 
            this.btnValidCompte.Location = new System.Drawing.Point(346, 313);
            this.btnValidCompte.Name = "btnValidCompte";
            this.btnValidCompte.Size = new System.Drawing.Size(121, 44);
            this.btnValidCompte.TabIndex = 1;
            this.btnValidCompte.Text = "Valider le compte";
            this.btnValidCompte.UseVisualStyleBackColor = true;
            this.btnValidCompte.Click += new System.EventHandler(this.btnValidCompte_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(600, 313);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(105, 35);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // bsClients
            // 
            this.bsClients.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.client);
            // 
            // vueValidationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValidCompte);
            this.Controls.Add(this.cbClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueValidationCompte";
            this.Text = "Validation d\'un Compte";
            this.Load += new System.EventHandler(this.vueValidationCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsClients;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Button btnValidCompte;
        private System.Windows.Forms.Button btnRetour;
    }
}