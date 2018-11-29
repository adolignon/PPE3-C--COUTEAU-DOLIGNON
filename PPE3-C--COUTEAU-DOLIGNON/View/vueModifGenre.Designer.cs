namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueModifGenre
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
            this.bsGenre = new System.Windows.Forms.BindingSource(this.components);
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbLibelleGenre = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(316, 74);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 0;
            // 
            // tbLibelleGenre
            // 
            this.tbLibelleGenre.Location = new System.Drawing.Point(316, 150);
            this.tbLibelleGenre.Name = "tbLibelleGenre";
            this.tbLibelleGenre.Size = new System.Drawing.Size(121, 20);
            this.tbLibelleGenre.TabIndex = 1;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(334, 249);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // vueModifGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.tbLibelleGenre);
            this.Controls.Add(this.cbGenre);
            this.Name = "vueModifGenre";
            this.Text = "vueModifGenre";
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbLibelleGenre;
        private System.Windows.Forms.Button btnModif;
    }
}