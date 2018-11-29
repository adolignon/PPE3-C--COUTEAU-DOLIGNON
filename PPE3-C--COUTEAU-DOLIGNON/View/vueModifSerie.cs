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
    public partial class vueModifSerie : Form
    {
        private string image;
        public vueModifSerie()
        {
            InitializeComponent();

            bsSerie.DataSource = Connexion.ListeDesSupports().Where(s => Connexion.ListeDesSeries().Select(se => se.idSerie).Contains(s.idSupport));
            cbSerie.DataSource = bsSerie;
            cbSerie.DisplayMember = "titreSupport";

            bsGenre.DataSource = Connexion.ListeDesGenre();
            cbGenre.DataSource = bsGenre;
            cbGenre.DisplayMember = "libelleGenre";
            cbGenre.SelectedItem = ((support)bsSerie.Current).genre;
            image = ((support)bsSerie.Current).image;
            tbResume.Text = ((support)bsSerie.Current).serie.resumeSerie;
            tbNom.Text = ((support)bsSerie.Current).titreSupport;
            tbRealisateur.Text = ((support)bsSerie.Current).realisateur;




        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Multiselect = false;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image = dialog.FileName;
                string[] res = image.Split('\\');
                image = res[res.Length-1];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbResume.Text != "" && tbNom.Text !="" && tbRealisateur.Text != "" && image!="")
            {
                
                Connexion.modifierSerie((support)bsSerie.Current,tbNom.Text,tbRealisateur.Text,((genre)cbGenre.SelectedItem).idGenre,tbResume.Text,image);
                MessageBox.Show("Modifié !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
        }

        private void bsFilm_CurrentChanged(object sender, EventArgs e)
        {
            cbGenre.SelectedItem = ((support)bsSerie.Current).genre;
            image = ((support)bsSerie.Current).image;
            tbResume.Text = ((support)bsSerie.Current).serie.resumeSerie;
            tbNom.Text = ((support)bsSerie.Current).titreSupport;
            tbRealisateur.Text = ((support)bsSerie.Current).realisateur;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
