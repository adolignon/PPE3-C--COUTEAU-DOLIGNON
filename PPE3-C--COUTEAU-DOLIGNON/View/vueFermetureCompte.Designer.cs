namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueFermetureCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueFermetureCompte));
            this.bsFermCompte = new System.Windows.Forms.BindingSource(this.components);
            this.cbFermClient = new System.Windows.Forms.ComboBox();
            this.btnFermCompte = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsFermCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFermCompte
            // 
            this.bsFermCompte.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.client);
            // 
            // cbFermClient
            // 
            this.cbFermClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFermClient.FormattingEnabled = true;
            this.cbFermClient.Location = new System.Drawing.Point(268, 71);
            this.cbFermClient.Name = "cbFermClient";
            this.cbFermClient.Size = new System.Drawing.Size(256, 21);
            this.cbFermClient.TabIndex = 0;
            // 
            // btnFermCompte
            // 
            this.btnFermCompte.Location = new System.Drawing.Point(296, 269);
            this.btnFermCompte.Name = "btnFermCompte";
            this.btnFermCompte.Size = new System.Drawing.Size(198, 23);
            this.btnFermCompte.TabIndex = 1;
            this.btnFermCompte.Text = "Fermer le compte";
            this.btnFermCompte.UseVisualStyleBackColor = true;
            this.btnFermCompte.Click += new System.EventHandler(this.btnFermCompte_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(598, 192);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 36);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // vueFermetureCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnFermCompte);
            this.Controls.Add(this.cbFermClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueFermetureCompte";
            this.Text = "Fermer un compte";
            this.Load += new System.EventHandler(this.vueFermetureCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFermCompte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFermCompte;
        private System.Windows.Forms.ComboBox cbFermClient;
        private System.Windows.Forms.Button btnFermCompte;
        private System.Windows.Forms.Button btnRetour;
    }
}