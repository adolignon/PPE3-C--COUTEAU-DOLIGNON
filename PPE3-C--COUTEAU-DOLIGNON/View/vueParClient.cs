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
    public partial class vueParClient : Form
    {
        public vueParClient()
        {
            InitializeComponent();
            bsClient.DataSource = Connexion.ListeDesClients();
            cbClient.DataSource = bsClient;
            cbClient.DisplayMember = "login";
            List<support> lesSupports = new List<support>();
            client leClient = (client)bsClient.Current;
            List<emprunt> lesEmprunts = leClient.emprunt.ToList();
            foreach (emprunt e in lesEmprunts)
            {
                lesSupports.Add(e.support);
            }
            bsSupport.DataSource = lesSupports;
        }

        private void bsClient_CurrentChanged(object sender, EventArgs e)
        {
            List<support> lesSupports = new List<support>();
            client leClient = (client)bsClient.Current;
            List<emprunt> lesEmprunts = leClient.emprunt.ToList();
            foreach (emprunt em in lesEmprunts)
            {
                lesSupports.Add(em.support);
            }
            bsSupport.DataSource = lesSupports;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
