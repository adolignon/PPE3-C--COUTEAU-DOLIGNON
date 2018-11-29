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
    public partial class vueParSupport : Form
    {
        public vueParSupport()
        {
            InitializeComponent();
            cbSupport.SelectedItem = "Film";
            List<support> supports = new List<support>();
            if (cbSupport.SelectedItem.ToString() == "Série")
            {
                List<serie> lesSeries = Connexion.ListeDesSeries();
                foreach(serie s in lesSeries)
                {
                    supports.Add(s.support);
                }
            }
            else
            {
                List<film> lesFilms = Connexion.ListeDesFilms();
                foreach (film f in lesFilms)
                {
                    supports.Add(f.support);
                }
            }
            bsSupport.DataSource = supports;
                
        }

        private void cbSupport_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<support> supports = new List<support>();
            if (cbSupport.SelectedItem.ToString() == "Série")
            {
                List<serie> lesSeries = Connexion.ListeDesSeries();
                foreach (serie s in lesSeries)
                {
                    supports.Add(s.support);
                }
            }
            else
            {
                List<film> lesFilms = Connexion.ListeDesFilms();
                foreach (film f in lesFilms)
                {
                    supports.Add(f.support);
                }
            }
            bsSupport.DataSource = supports;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
