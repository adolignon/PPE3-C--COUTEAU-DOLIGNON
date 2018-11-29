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
    public partial class vueModifSaison : Form
    {
        public vueModifSaison()
        {
            InitializeComponent();
            bsSerie.DataSource = Connexion.ListeDesSupports().Where(s => Connexion.ListeDesSeries().Select(se => se.idSerie).Contains(s.idSupport));
            cbSerie.DataSource = bsSerie;
            cbSerie.DisplayMember = "titreSupport";
            bsSaison.DataSource = ((support)bsSerie.Current).serie.saison.ToList();
            cbSaison.DataSource = bsSaison;
            cbSaison.DisplayMember = "numSaison";
            nupAnnee.Value = ((saison)bsSaison.Current).anneeSaison;
            nupNbEp.Value = ((saison)bsSaison.Current).nbrEpisodesPrevus;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsSerie_CurrentChanged(object sender, EventArgs e)
        {
            bsSaison.DataSource = ((support)bsSerie.Current).serie.saison.ToList();
            cbSaison.DataSource = bsSaison;
            cbSaison.DisplayMember = "numSaison";
            nupAnnee.Value = ((saison)bsSaison.Current).anneeSaison;
            nupNbEp.Value = ((saison)bsSaison.Current).nbrEpisodesPrevus;
        }

        private void bsSaison_CurrentChanged(object sender, EventArgs e)
        {
            nupAnnee.Value = ((saison)bsSaison.Current).anneeSaison;
            nupNbEp.Value = ((saison)bsSaison.Current).nbrEpisodesPrevus;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Connexion.modifierSaison(((support)bsSerie.Current).serie,(saison)bsSaison.Current,nupAnnee.Value,nupNbEp.Value);
            MessageBox.Show("Modifié !");
            this.Close();
        }
    }
}
