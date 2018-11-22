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
    }
}
