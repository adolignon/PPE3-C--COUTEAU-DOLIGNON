using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPE3_C__COUTEAU_DOLIGNON.Model;

namespace PPE3_C__COUTEAU_DOLIGNON.Model
{
    public static class Connexion
    {
        static ppe3Connexion maConnexion;
        public static void init()
        {
            maConnexion = new ppe3Connexion();   
        }

        public static List<client> ListeDesClients()
        {
            return maConnexion.client.ToList();
        }

        public static List<saison> ListeDesSaison()
        {
            return maConnexion.saison.ToList();
        }

        public static List<serie> ListeDesSeries()
        {
            return maConnexion.serie.ToList();
        }

        public static List<film> ListeDesFilms()
        {
            return maConnexion.film.ToList();
        }

        public static void setActif(client leClient)
        {
            maConnexion.client.Find(leClient.idClient).actif = 1;
            maConnexion.SaveChanges();
            
        }

        public static List<genre> ListeDesGenre()
        {
            return maConnexion.genre.ToList();
        }

        public static List<emprunt> ListeDesEmprunts()
        {
            return maConnexion.emprunt.ToList();
        }

        public static List<episode> ListeDesEpisodes()
        {
            return maConnexion.episode.ToList();
        }

        public static List<support> ListeDesSupports()
        {
            return maConnexion.support.ToList();
        }

        public static void fermetureCompte(client leClient)
        {
            maConnexion.client.Find(leClient.idClient).actif = 2;
            maConnexion.SaveChanges();
        }

        internal static void modifClient(client leClient, string nomCli, string prenomCli, string emailCli, string loginCli, string pwdCli, DateTime dateNaissCli)
        {
            maConnexion.client.Find(leClient.idClient).nomClient = nomCli;
            maConnexion.client.Find(leClient.idClient).prenomClient = prenomCli;
            maConnexion.client.Find(leClient.idClient).emailClient = emailCli;
            maConnexion.client.Find(leClient.idClient).login = loginCli;
            maConnexion.client.Find(leClient.idClient).pwd = pwdCli;
            maConnexion.client.Find(leClient.idClient).dateNaissClient = dateNaissCli;
            maConnexion.SaveChanges();

        }

        public static void ajoutCompte(client leClient)
        {
            maConnexion.client.Add(leClient);
            maConnexion.SaveChanges();
        }

    }
}
