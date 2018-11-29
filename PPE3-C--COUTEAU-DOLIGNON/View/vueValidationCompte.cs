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
    public partial class vueValidationCompte : Form
    {
        public vueValidationCompte()
        {
            InitializeComponent();
            bsClients.DataSource = Connexion.ListeDesClients();
            cbClients.DataSource = bsClients;
            cbClients.DisplayMember = "login";
        }

        private void vueValidationCompte_Load(object sender, EventArgs e)
        {

        }

        private void btnValidCompte_Click(object sender, EventArgs e)
        {
            if(((client)bsClients.Current).actif == 1)
            {
                MessageBox.Show("Le client " + ((client)bsClients.Current).login.Trim() + " est déjà actif");
            }
            else
            {
                Connexion.setActif((client)bsClients.Current);
                MessageBox.Show("Le client " + ((client)bsClients.Current).login.Trim() + " est désormais actif");
            }
            this.Close();
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
