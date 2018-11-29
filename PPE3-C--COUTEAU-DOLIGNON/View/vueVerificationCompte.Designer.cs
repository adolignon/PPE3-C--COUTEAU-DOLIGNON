namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueVerificationCompte
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
            this.cbActifInactif = new System.Windows.Forms.ComboBox();
            this.lbVerifClient = new System.Windows.Forms.ListBox();
            this.bsVerifClient = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVerifClient)).BeginInit();
            this.SuspendLayout();
            // 
            // cbActifInactif
            // 
            this.cbActifInactif.FormattingEnabled = true;
            this.cbActifInactif.Items.AddRange(new object[] {
            "Actif",
            "Inactif"});
            this.cbActifInactif.Location = new System.Drawing.Point(278, 75);
            this.cbActifInactif.Name = "cbActifInactif";
            this.cbActifInactif.Size = new System.Drawing.Size(277, 21);
            this.cbActifInactif.TabIndex = 0;
            this.cbActifInactif.SelectedIndexChanged += new System.EventHandler(this.cbActifInactif_SelectedIndexChanged);
            // 
            // lbVerifClient
            // 
            this.lbVerifClient.FormattingEnabled = true;
            this.lbVerifClient.Location = new System.Drawing.Point(278, 181);
            this.lbVerifClient.Name = "lbVerifClient";
            this.lbVerifClient.Size = new System.Drawing.Size(277, 316);
            this.lbVerifClient.TabIndex = 2;
            this.lbVerifClient.DoubleClick += new System.EventHandler(this.lbVerifClient_DoubleClick);
            // 
            // bsVerifClient
            // 
            this.bsVerifClient.CurrentChanged += new System.EventHandler(this.bsVerifClient_CurrentChanged);
            // 
            // vueVerificationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.lbVerifClient);
            this.Controls.Add(this.cbActifInactif);
            this.Name = "vueVerificationCompte";
            this.Text = "Vérifier un compte";
            this.Load += new System.EventHandler(this.vueVerificationCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVerifClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbActifInactif;
        private System.Windows.Forms.ListBox lbVerifClient;
        private System.Windows.Forms.BindingSource bsVerifClient;
    }
}