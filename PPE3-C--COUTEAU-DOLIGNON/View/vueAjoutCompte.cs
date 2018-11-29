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
    public partial class vueAjoutCompte : Form
    {
        public vueAjoutCompte()
        {
            InitializeComponent();
        }

        private void vueAjoutCompte_Load(object sender, EventArgs e)
        {

        }

        private void btnCreaCompte_Click(object sender, EventArgs e)
        {
            if(tbNomCli.Text == "" || tbPrenomCli.Text == "" || tbEmail.Text == "" || tbLogin.Text == "" || tbPwd.Text == "" || tbConfirmPwd.Text == "")
            {
                MessageBox.Show("Seule la date de naissance n'est pas obligatoire, les autres champs sont obligatoires et ne peuvent donc pas être vide !");
            }
            else
            {
                if (tbPwd.Text != tbConfirmPwd.Text)
                {
                    MessageBox.Show("Le mot de passe n'est pas identique !");
                }
                else
                {
                    client leClient = new client();
                    leClient.idClient = Connexion.ListeDesClients().Count+1;
                    leClient.nomClient = tbNomCli.Text;
                    leClient.prenomClient = tbPrenomCli.Text;
                    leClient.emailClient = tbEmail.Text;
                    leClient.dateAbonnementClient = DateTime.Now;
                    leClient.login = tbLogin.Text;
                    leClient.pwd = tbPwd.Text;
                    leClient.actif = 0;
                    leClient.dateNaissClient = dtpDateNaiss.Value;
                    Connexion.ajoutCompte(leClient);
                    MessageBox.Show("Ajout effectué avec succès !");
                    this.Close();
                }
            }
            
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
