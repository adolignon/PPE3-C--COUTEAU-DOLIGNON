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
    public partial class vueModifGenre : Form
    {
        public vueModifGenre()
        {
            InitializeComponent();
            bsGenre.DataSource = Connexion.ListeDesGenre();
            cbGenre.DataSource = bsGenre;
            cbGenre.DisplayMember = "libelleGenre";

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Connexion.modifierGenre((genre)bsGenre.Current,tbLibelleGenre.Text);
            MessageBox.Show("Modifié !");
            this.Close();
        }
    }
}
