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
    public partial class vueSupportParGenre : Form
    {
        public vueSupportParGenre()
        {
            InitializeComponent();
            bsGenre.DataSource = Connexion.ListeDesGenre();
            cbGenre.DataSource = bsGenre;
            cbGenre.DisplayMember = "libelleGenre";
            bsSupport.DataSource = ((genre)bsGenre.Current).support.ToList();
        }

        private void bsGenre_CurrentChanged(object sender, EventArgs e)
        {
            bsSupport.DataSource = ((genre)bsGenre.Current).support.ToList();
        }

        private void vueSupportParGenre_Load(object sender, EventArgs e)
        {

        }
    }
}
