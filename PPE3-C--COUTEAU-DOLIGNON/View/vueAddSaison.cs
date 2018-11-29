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
    public partial class vueAddSaison : Form
    {
        public vueAddSaison()
        {
            InitializeComponent();
            bsSerie.DataSource = Connexion.ListeDesSupports().Where(s => Connexion.ListeDesSeries().Select(se => se.idSerie).Contains(s.idSupport));
            cbSerie.DataSource = bsSerie;
            cbSerie.DisplayMember = "titreSupport";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connexion.ajouterSaison(((support)bsSerie.Current).serie, nupAnnee.Value, nupNbEp.Value);
            MessageBox.Show("Ajouté !");
            this.Close();
        }

    }
}
