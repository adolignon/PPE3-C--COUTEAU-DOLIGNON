namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class btnRetour
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
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(306, 116);
            this.tbGenre.MaxLength = 32;
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(161, 20);
            this.tbGenre.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(345, 224);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.BackColor = System.Drawing.Color.Transparent;
            this.labelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.Color.White;
            this.labelAdd.Location = new System.Drawing.Point(285, 51);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(203, 27);
            this.labelAdd.TabIndex = 2;
            this.labelAdd.Text = "Ajouter un genre :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRetour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbGenre);
            this.Name = "btnRetour";
            this.Text = "vueAddGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button button1;
    }
}