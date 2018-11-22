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
            this.bsFermCompte = new System.Windows.Forms.BindingSource(this.components);
            this.cbFermClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsFermCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFermCompte
            // 
            this.bsFermCompte.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.client);
            // 
            // cbFermClient
            // 
            this.cbFermClient.FormattingEnabled = true;
            this.cbFermClient.Location = new System.Drawing.Point(268, 71);
            this.cbFermClient.Name = "cbFermClient";
            this.cbFermClient.Size = new System.Drawing.Size(256, 21);
            this.cbFermClient.TabIndex = 0;
            // 
            // vueFermetureCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.cbFermClient);
            this.Name = "vueFermetureCompte";
            this.Text = "vueFermetureCompte";
            this.Load += new System.EventHandler(this.vueFermetureCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFermCompte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFermCompte;
        private System.Windows.Forms.ComboBox cbFermClient;
    }
}