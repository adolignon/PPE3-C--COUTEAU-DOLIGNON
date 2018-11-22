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
    public partial class vueParReferenceClient : Form
    {
        public vueParReferenceClient()
        {
            InitializeComponent();
            bsRef.DataSource = Connexion.ListeDesEmprunts();
            cbRef.DataSource = bsRef;
            cbRef.DisplayMember = "idEmprunt";
            bsSupport.DataSource = ((emprunt)bsRef.Current).support;
        }

        private void bsRef_CurrentChanged(object sender, EventArgs e)
        {
            bsSupport.DataSource = ((emprunt)bsRef.Current).support;
        }
    }
}
