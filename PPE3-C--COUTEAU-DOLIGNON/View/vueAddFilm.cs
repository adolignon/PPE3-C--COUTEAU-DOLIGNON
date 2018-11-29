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
    public partial class vueAddFilm : Form
    {
        private string image;
        public vueAddFilm()
        {
            InitializeComponent();
            image = "";
            bsGenre.DataSource = Connexion.ListeDesGenre();
            cbGenre.DataSource = bsGenre;
            cbGenre.DisplayMember = "libelleGenre";
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
                support leSupport = new support();
                film leFilm = new film();
                leSupport.idSupport = Connexion.ListeDesSupports().Count()+1;
                leSupport.titreSupport = tbNom.Text;
                leSupport.realisateur = tbRealisateur.Text;
                leSupport.image = image;
                leSupport.idGenre = ((genre)bsGenre.Current).idGenre;
                Connexion.ajouterSupport(leSupport);
                leFilm.idFilm = leSupport.idSupport;
                leFilm.duree = tbDurée.Text;
                Connexion.ajouterFilm(leFilm);
                MessageBox.Show("Ajouté !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
        }
    }
}
