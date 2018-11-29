using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3_C__COUTEAU_DOLIGNON.View;

namespace PPE3_C__COUTEAU_DOLIGNON
{
    public partial class Controlleur : Form
    {
        public Controlleur()
        {
            InitializeComponent();
        }

        private void ajoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueSupportParGenre laVue = new vueSupportParGenre();
            laVue.Show();
        }

        private void validationDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueValidationCompte validCompte = new vueValidationCompte();
            validCompte.Show();
        }

        private void vérificationDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueVerificationCompte verifCompte = new vueVerificationCompte();
            verifCompte.Show();
		}
		
        private void parSUpportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueParSupport laVue = new vueParSupport();
            laVue.Show();
        }

        private void parClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueParClient laVue = new vueParClient();
            laVue.Show();
        }

        private void parReferenceEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueParReferenceClient laVue = new vueParReferenceClient();
            laVue.Show();
        }

        private void parDateAbonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueParDateAbonnement laVue = new vueParDateAbonnement();
            laVue.Show();
        }

        private void fermetureDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueFermetureCompte fermetureCompte = new vueFermetureCompte();
            fermetureCompte.Show();
        }

        private void ajoutDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueAjoutCompte ajoutCompte = new vueAjoutCompte();
            ajoutCompte.Show();
        }

        private void ajoutToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            vueAjoutCompte ajoutCompte = new vueAjoutCompte();
            ajoutCompte.Show();
        }

        private void modificationToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            vueModifClient modifClient = new vueModifClient();
            modifClient.Show();
        }

        private void Controlleur_Load(object sender, EventArgs e)
        {

        }
    }
}
