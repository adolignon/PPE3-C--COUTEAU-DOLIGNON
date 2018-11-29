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
    public partial class vueModifFilm : Form
    {
        private string image;
        public vueModifFilm()
        {
            InitializeComponent();

            bsFilm.DataSource = Connexion.ListeDesSupports().Where(s => Connexion.ListeDesFilms().Select(f => f.idFilm).Contains(s.idSupport));
            cbFilm.DataSource = bsFilm;
            cbFilm.DisplayMember = "titreSupport";

            bsGenre.DataSource = Connexion.ListeDesGenre();
            cbGenre.DataSource = bsGenre;
            cbGenre.DisplayMember = "libelleGenre";
            cbGenre.SelectedItem = ((support)bsFilm.Current).genre;
            image = ((support)bsFilm.Current).image;
            tbDurée.Text = ((support)bsFilm.Current).film.duree;
            tbNom.Text = ((support)bsFilm.Current).titreSupport;
            tbRealisateur.Text = ((support)bsFilm.Current).realisateur;




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
            if(tbDurée.Text != "" && tbNom.Text !="" && tbRealisateur.Text != "" && image!="")
            {
                
                Connexion.modifierFilm((support)bsFilm.Current,tbNom.Text,tbRealisateur.Text,((genre)cbGenre.SelectedItem).idGenre,tbDurée.Text,image);
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
            cbGenre.SelectedItem = ((support)bsFilm.Current).genre;
            image = ((support)bsFilm.Current).image;
            tbDurée.Text = ((support)bsFilm.Current).film.duree;
            tbNom.Text = ((support)bsFilm.Current).titreSupport;
            tbRealisateur.Text = ((support)bsFilm.Current).realisateur;
        }
    }
}
