using PPE3_C__COUTEAU_DOLIGNON.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_C__COUTEAU_DOLIGNON.View
{
    public partial class vueModifClient : Form
    {
        
        public vueModifClient()
        {
            InitializeComponent();
            bsClients.DataSource = Connexion.ListeDesClients();
            cbModifCli.DataSource = bsClients;
            cbModifCli.DisplayMember = "login";
            tbNomCli.Text = ((client)bsClients.Current).nomClient.Trim();
            tbPrenomCli.Text = ((client)bsClients.Current).prenomClient.Trim();
            tbPrenomCli.Text = ((client)bsClients.Current).prenomClient.Trim();
            dtpDateNaiss.Value = ((DateTime)((client)bsClients.Current).dateNaissClient);
            tbEmail.Text = ((client)bsClients.Current).emailClient.Trim();
            tbLogin.Text = ((client)bsClients.Current).login.Trim();
            tbPwd.Text = ((client)bsClients.Current).pwd.Trim();
        }

        private void btnModifCli_Click(object sender, EventArgs e)
        {
            if (tbNomCli.Text == "" || tbPrenomCli.Text == "" || tbEmail.Text == "" || tbLogin.Text == "" || tbPwd.Text == "")
            {
                MessageBox.Show("Seule la date de naissance n'est pas obligatoire, les autres champs sont obligatoires et ne peuvent donc pas être vide !");
            }
            else
            {
                    client leClient = (client)bsClients.Current;
                    Connexion.modifClient(leClient,tbNomCli.Text, tbPrenomCli.Text, tbEmail.Text, tbLogin.Text, tbPwd.Text, dtpDateNaiss.Value);
                    MessageBox.Show("Modification effectuée avec succès !");
                    this.Close();
            }
        }

        private void bsClients_CurrentChanged(object sender, EventArgs e)
        {
            tbNomCli.Text = ((client)bsClients.Current).nomClient.Trim();
            tbPrenomCli.Text = ((client)bsClients.Current).prenomClient.Trim();
            tbPrenomCli.Text = ((client)bsClients.Current).prenomClient.Trim();
            dtpDateNaiss.Value = ((DateTime)((client)bsClients.Current).dateNaissClient);
            tbEmail.Text = ((client)bsClients.Current).emailClient.Trim();
            tbLogin.Text = ((client)bsClients.Current).login.Trim();
            tbPwd.Text = ((client)bsClients.Current).pwd.Trim();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
