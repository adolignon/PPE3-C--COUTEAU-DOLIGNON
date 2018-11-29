namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueParClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueParClient));
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.dgSupport = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.idSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSupport = new System.Windows.Forms.BindingSource(this.components);
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupport)).BeginInit();
            this.SuspendLayout();
            //
            // cbClient
            //
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(34, 33);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 21);
            this.cbClient.TabIndex = 0;
            //
            // dgSupport
            //
            this.dgSupport.AutoGenerateColumns = false;
            this.dgSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSupportDataGridViewTextBoxColumn,
            this.titreSupportDataGridViewTextBoxColumn,
            this.realisateurDataGridViewTextBoxColumn});
            this.dgSupport.DataSource = this.bsSupport;
            this.dgSupport.Location = new System.Drawing.Point(171, 91);
            this.dgSupport.Name = "dgSupport";
            this.dgSupport.Size = new System.Drawing.Size(408, 282);
            this.dgSupport.TabIndex = 1;
            //
            // bsClient
            //
            this.bsClient.CurrentChanged += new System.EventHandler(this.bsClient_CurrentChanged);
            //
            // btnRetour
            //
            this.btnRetour.Location = new System.Drawing.Point(654, 220);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(96, 40);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            //
            // idSupportDataGridViewTextBoxColumn
            //
            this.idSupportDataGridViewTextBoxColumn.DataPropertyName = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.HeaderText = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.Name = "idSupportDataGridViewTextBoxColumn";
            //
            // titreSupportDataGridViewTextBoxColumn
            //
            this.titreSupportDataGridViewTextBoxColumn.DataPropertyName = "titreSupport";
            this.titreSupportDataGridViewTextBoxColumn.HeaderText = "titreSupport";
            this.titreSupportDataGridViewTextBoxColumn.Name = "titreSupportDataGridViewTextBoxColumn";
            //
            // realisateurDataGridViewTextBoxColumn
            //
            this.realisateurDataGridViewTextBoxColumn.DataPropertyName = "realisateur";
            this.realisateurDataGridViewTextBoxColumn.HeaderText = "realisateur";
            this.realisateurDataGridViewTextBoxColumn.Name = "realisateurDataGridViewTextBoxColumn";
            //
            // bsSupport
            //
            this.bsSupport.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.support);
            //
            // bsClient
            //
            this.bsSupport.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.support);
            //
            // vueParClient
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dgSupport);
            this.Controls.Add(this.cbClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueParClient";
            this.Text = "Affichage par client";
            ((System.ComponentModel.ISupportInitialize)(this.dgSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.DataGridView dgSupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSupport;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.Button btnRetour;
    }
}
