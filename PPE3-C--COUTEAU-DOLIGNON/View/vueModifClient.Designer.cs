namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    partial class vueModifClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vueModifClient));
            this.cbModifCli = new System.Windows.Forms.ComboBox();
            this.btnModifCli = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.tbPrenomCli = new System.Windows.Forms.TextBox();
            this.tbNomCli = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.lblPrenomCli = new System.Windows.Forms.Label();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.lblModifCompte = new System.Windows.Forms.Label();
            this.bsClients = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModifCli
            // 
            this.cbModifCli.FormattingEnabled = true;
            this.cbModifCli.Location = new System.Drawing.Point(12, 78);
            this.cbModifCli.Name = "cbModifCli";
            this.cbModifCli.Size = new System.Drawing.Size(284, 21);
            this.cbModifCli.TabIndex = 2;
            // 
            // btnModifCli
            // 
            this.btnModifCli.Location = new System.Drawing.Point(255, 362);
            this.btnModifCli.Name = "btnModifCli";
            this.btnModifCli.Size = new System.Drawing.Size(284, 57);
            this.btnModifCli.TabIndex = 3;
            this.btnModifCli.Text = "Modifier le client";
            this.btnModifCli.UseVisualStyleBackColor = true;
            this.btnModifCli.Click += new System.EventHandler(this.btnModifCli_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(592, 197);
            this.tbPwd.MaxLength = 30;
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(189, 20);
            this.tbPwd.TabIndex = 28;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(592, 140);
            this.tbLogin.MaxLength = 30;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(189, 20);
            this.tbLogin.TabIndex = 27;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(158, 305);
            this.tbEmail.MaxLength = 32;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(189, 20);
            this.tbEmail.TabIndex = 26;
            // 
            // dtpDateNaiss
            // 
            this.dtpDateNaiss.Location = new System.Drawing.Point(159, 249);
            this.dtpDateNaiss.Name = "dtpDateNaiss";
            this.dtpDateNaiss.Size = new System.Drawing.Size(188, 20);
            this.dtpDateNaiss.TabIndex = 25;
            // 
            // tbPrenomCli
            // 
            this.tbPrenomCli.Location = new System.Drawing.Point(158, 197);
            this.tbPrenomCli.MaxLength = 60;
            this.tbPrenomCli.Name = "tbPrenomCli";
            this.tbPrenomCli.Size = new System.Drawing.Size(189, 20);
            this.tbPrenomCli.TabIndex = 24;
            // 
            // tbNomCli
            // 
            this.tbNomCli.Location = new System.Drawing.Point(158, 139);
            this.tbNomCli.MaxLength = 60;
            this.tbNomCli.Name = "tbNomCli";
            this.tbNomCli.Size = new System.Drawing.Size(189, 20);
            this.tbNomCli.TabIndex = 23;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.Color.White;
            this.lblPwd.Location = new System.Drawing.Point(476, 199);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(110, 18);
            this.lblPwd.TabIndex = 22;
            this.lblPwd.Text = "Mot de passe :";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(495, 141);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(91, 18);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Identifiant :";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(89, 304);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 18);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "E-mail :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNaiss.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaiss.ForeColor = System.Drawing.Color.White;
            this.lblDateNaiss.Location = new System.Drawing.Point(7, 252);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(145, 18);
            this.lblDateNaiss.TabIndex = 19;
            this.lblDateNaiss.Text = "Date de naissance :";
            this.lblDateNaiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrenomCli
            // 
            this.lblPrenomCli.AutoSize = true;
            this.lblPrenomCli.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenomCli.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomCli.ForeColor = System.Drawing.Color.White;
            this.lblPrenomCli.Location = new System.Drawing.Point(79, 196);
            this.lblPrenomCli.Name = "lblPrenomCli";
            this.lblPrenomCli.Size = new System.Drawing.Size(73, 18);
            this.lblPrenomCli.TabIndex = 18;
            this.lblPrenomCli.Text = "Prénom :";
            this.lblPrenomCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.Transparent;
            this.lblNomCli.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.ForeColor = System.Drawing.Color.White;
            this.lblNomCli.Location = new System.Drawing.Point(101, 139);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(51, 18);
            this.lblNomCli.TabIndex = 17;
            this.lblNomCli.Text = "Nom :";
            this.lblNomCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModifCompte
            // 
            this.lblModifCompte.AutoSize = true;
            this.lblModifCompte.BackColor = System.Drawing.Color.Transparent;
            this.lblModifCompte.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifCompte.ForeColor = System.Drawing.Color.White;
            this.lblModifCompte.Location = new System.Drawing.Point(311, 9);
            this.lblModifCompte.Name = "lblModifCompte";
            this.lblModifCompte.Size = new System.Drawing.Size(252, 24);
            this.lblModifCompte.TabIndex = 16;
            this.lblModifCompte.Text = "Modification d\'un compte";
            this.lblModifCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bsClients
            // 
            this.bsClients.DataSource = typeof(PPE3_C__COUTEAU_DOLIGNON.Model.client);
            this.bsClients.CurrentChanged += new System.EventHandler(this.bsClients_CurrentChanged);
            // 
            // vueModifClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_C__COUTEAU_DOLIGNON.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.dtpDateNaiss);
            this.Controls.Add(this.tbPrenomCli);
            this.Controls.Add(this.tbNomCli);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblPrenomCli);
            this.Controls.Add(this.lblNomCli);
            this.Controls.Add(this.lblModifCompte);
            this.Controls.Add(this.btnModifCli);
            this.Controls.Add(this.cbModifCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vueModifClient";
            this.Text = "Modifier un client";
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsClients;
        private System.Windows.Forms.ComboBox cbModifCli;
        private System.Windows.Forms.Button btnModifCli;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpDateNaiss;
        private System.Windows.Forms.TextBox tbPrenomCli;
        private System.Windows.Forms.TextBox tbNomCli;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblPrenomCli;
        private System.Windows.Forms.Label lblNomCli;
        private System.Windows.Forms.Label lblModifCompte;
    }
}