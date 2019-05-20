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
    public partial class vueFermetureCompte : Form
    {
        public vueFermetureCompte()
        {
            InitializeComponent();
            bsFermCompte.DataSource = Connexion.ListeDesClients().Where(c => c.actif != 2);
            cbFermClient.DataSource = bsFermCompte;
            cbFermClient.DisplayMember = "login";
        }

        private void vueFermetureCompte_Load(object sender, EventArgs e)
        {

        }

        private void btnFermCompte_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous fermer le compte de " + cbFermClient.Text.Trim() + " ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connexion.fermetureCompte((client)cbFermClient.SelectedValue);
                this.Close();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
