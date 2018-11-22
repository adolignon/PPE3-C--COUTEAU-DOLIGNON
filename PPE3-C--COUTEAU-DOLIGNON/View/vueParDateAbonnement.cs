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
    public partial class vueParDateAbonnement : Form
    {
        public vueParDateAbonnement()
        {
            InitializeComponent();
            List<emprunt> lesEmprunts = Connexion.ListeDesEmprunts().OrderBy(x => x.dateEmprunt).ToList();
            List<DateTime> lesDates = new List<DateTime>();
            foreach(emprunt e in lesEmprunts)
            {
                if(!lesDates.Contains(e.dateEmprunt))
                    lesDates.Add(e.dateEmprunt);
            }
            bsDate.DataSource = lesDates;
            cbDate.DataSource = bsDate;
            List<emprunt> lesEmpruntsADate = lesEmprunts.Where(e => e.dateEmprunt == (DateTime)bsDate.Current).ToList();
            List<support> lesSupport = new List<support>();
            foreach(emprunt e in lesEmpruntsADate)
            {
                lesSupport.Add(e.support);
            }
            bsSupport.DataSource = lesSupport;

        }

        private void bsDate_CurrentChanged(object sender, EventArgs e)
        {
            List<emprunt> lesEmprunts = Connexion.ListeDesEmprunts().OrderBy(x => x.dateEmprunt).ToList();
            List<emprunt> lesEmpruntsADate = lesEmprunts.Where(em => em.dateEmprunt == (DateTime)bsDate.Current).ToList();
            List<support> lesSupport = new List<support>();
            foreach (emprunt em in lesEmpruntsADate)
            {
                lesSupport.Add(em.support);
            }
            bsSupport.DataSource = lesSupport;
        }
    }
}
