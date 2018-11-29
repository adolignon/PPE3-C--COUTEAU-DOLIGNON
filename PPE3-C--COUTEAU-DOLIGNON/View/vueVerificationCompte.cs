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
    public partial class vueVerificationCompte : Form
    {
        public vueVerificationCompte()
        {
            InitializeComponent();
            cbActifInactif.SelectedIndex = 0;
            if (cbActifInactif.SelectedItem.ToString() == "Actif")
            {
                if (Connexion.ListeDesClients().Where(c => c.actif == 1).Count() != 0)
                    bsVerifClient.DataSource = Connexion.ListeDesClients().Where(c => c.actif == 1);
                else
                    bsVerifClient.DataSource = new List<string>() { "Il n'existe pas de clients ACTIFS" };
            }
            else
            {
                if (Connexion.ListeDesClients().Where(c => c.actif == 0).Count() != 0)
                    bsVerifClient.DataSource = Connexion.ListeDesClients().Where(c => c.actif == 0);
                else
                    bsVerifClient.DataSource = new List<string>() { "Il n'existe pas de clients INACTIFS" };
            }
            lbVerifClient.DataSource = bsVerifClient;
            lbVerifClient.DisplayMember = "login";


            
        }

        private void vueVerificationCompte_Load(object sender, EventArgs e)
        {
           
        }

        private void bsVerifClient_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void cbActifInactif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActifInactif.SelectedItem.ToString() == "Actif")
            {
                if (Connexion.ListeDesClients().Where(c => c.actif == 1).Count() != 0)
                    bsVerifClient.DataSource = Connexion.ListeDesClients().Where(c => c.actif == 1);
                else
                    bsVerifClient.DataSource = new List<string>() { "Il n'existe pas de clients ACTIFS" };
            }
            else
            {
                if (Connexion.ListeDesClients().Where(c => c.actif == 0).Count() != 0)
                    bsVerifClient.DataSource = Connexion.ListeDesClients().Where(c => c.actif == 0);
                else
                    bsVerifClient.DataSource = new List<string>() { "Il n'existe pas de clients INACTIFS" };
            }
            lbVerifClient.DataSource = bsVerifClient;
            lbVerifClient.DisplayMember = "login";
        }

        private void lbVerifClient_DoubleClick(object sender, EventArgs e)
        {
            if(cbActifInactif.SelectedItem.ToString() == "Inactif")
            {
                if(MessageBox.Show("Voulez-vous activer cette personne ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Connexion.setActif((client)lbVerifClient.SelectedItem);
                    this.Close();
                }
                
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
