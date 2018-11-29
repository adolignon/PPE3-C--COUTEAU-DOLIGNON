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
    public partial class vueAddGenre : Form
    {
        public vueAddGenre()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(tbGenre.Text != "")
            {
                Connexion.ajouterGenre(tbGenre.Text);
                MessageBox.Show("Ajouté !");
                this.Close();
            }
        }
    }
}
