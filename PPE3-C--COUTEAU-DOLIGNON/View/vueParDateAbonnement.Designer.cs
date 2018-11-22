namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueParDateAbonnement
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
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.dgSupport = new System.Windows.Forms.DataGridView();
            this.bsDate = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSupport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(68, 25);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(121, 21);
            this.cbDate.TabIndex = 0;
            // 
            // dgSupport
            // 
            this.dgSupport.AutoGenerateColumns = false;
            this.dgSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgSupport.DataSource = this.bsSupport;
            this.dgSupport.Location = new System.Drawing.Point(199, 107);
            this.dgSupport.Name = "dgSupport";
            this.dgSupport.Size = new System.Drawing.Size(404, 257);
            this.dgSupport.TabIndex = 2;
            // 
            // bsDate
            // 
            this.bsDate.CurrentChanged += new System.EventHandler(this.bsDate_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSupport";
            this.dataGridViewTextBoxColumn1.HeaderText = "idSupport";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titreSupport";
            this.dataGridViewTextBoxColumn2.HeaderText = "titreSupport";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "realisateur";
            this.dataGridViewTextBoxColumn3.HeaderText = "realisateur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bsSupport
            // 
            this.bsSupport.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.support);
            // 
            // vueParDateAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSupport);
            this.Controls.Add(this.cbDate);
            this.Name = "vueParDateAbonnement";
            this.Text = "vueParDateAbonnement";
            ((System.ComponentModel.ISupportInitialize)(this.dgSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.BindingSource bsSupport;
        private System.Windows.Forms.DataGridView dgSupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource bsDate;
    }
}