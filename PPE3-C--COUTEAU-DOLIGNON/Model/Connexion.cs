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

        internal static void ajouterGenre(string libelleGenre)
        {
            genre leGenre = new genre();
            leGenre.idGenre = ListeDesGenre().Count();
            leGenre.libelleGenre = libelleGenre;
            maConnexion.genre.Add(leGenre);
            maConnexion.SaveChanges();
        }

        internal static void ajouterSaison(serie current, decimal annee, decimal nbEp)
        {
            saison laSaison = new saison();
            laSaison.idSerie = current.idSerie;
            laSaison.nbrEpisodesPrevus = Convert.ToInt32(nbEp);
            laSaison.anneeSaison = Convert.ToInt32(annee);
            laSaison.numSaison = maConnexion.serie.Find(current.idSerie).saison.Count+1;
            maConnexion.serie.Find(current.idSerie).saison.Add(laSaison);
            maConnexion.SaveChanges();
        }

        internal static void modifierGenre(genre current, string libelle)
        {
            maConnexion.genre.Find(current.idGenre).libelleGenre = libelle;
            maConnexion.SaveChanges();
        }

        public static List<serie> ListeDesSeries()
        {
            return maConnexion.serie.ToList();
        }

        public static List<film> ListeDesFilms()
        {
            return maConnexion.film.ToList();
        }

        internal static void modifierSaison(serie laSerie, saison laSaison, decimal annee, decimal nbEp)
        {
            maConnexion.saison.Find(laSerie.idSerie,laSaison.numSaison).nbrEpisodesPrevus = Convert.ToInt32(nbEp);
            maConnexion.saison.Find(laSerie.idSerie, laSaison.numSaison).anneeSaison = Convert.ToInt32(annee);
            maConnexion.SaveChanges();
        }

        public static void setActif(client leClient)
        {
            maConnexion.client.Find(leClient.idClient).actif = 1;
            maConnexion.SaveChanges();
            
        }

        internal static void ajouterSerie(serie laSerie)
        {
            maConnexion.serie.Add(laSerie);
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

        internal static void modifierSerie(support current, string nom, string realisateur, int idGenre, string resume, string image)
        {
            maConnexion.support.Find(current.idSupport).titreSupport = nom;
            maConnexion.support.Find(current.idSupport).realisateur = realisateur;
            maConnexion.support.Find(current.idSupport).image = image;
            maConnexion.support.Find(current.idSupport).idGenre = idGenre;
            maConnexion.serie.Find(current.idSupport).resumeSerie = resume;
            maConnexion.SaveChanges();
        }

        internal static void modifierFilm(support current, string nom, string realisateur, int idGenre, string duree, string image)
        {
            maConnexion.support.Find(current.idSupport).titreSupport = nom;
            maConnexion.support.Find(current.idSupport).realisateur = realisateur;
            maConnexion.support.Find(current.idSupport).image = image;
            maConnexion.support.Find(current.idSupport).idGenre = idGenre;
            maConnexion.film.Find(current.idSupport).duree = duree;
            maConnexion.SaveChanges();

        }

        internal static void ajouterSupport(support leSupport)
        {
            maConnexion.support.Add(leSupport);
            maConnexion.SaveChanges();
        }

        internal static void ajouterFilm(film leFilm)
        {
            maConnexion.film.Add(leFilm);
            maConnexion.SaveChanges();
        }

        public static List<episode> ListeDesEpisodes()
        {
            return maConnexion.episode.ToList();
        }

        public static List<support> ListeDesSupports()
        {
            return maConnexion.support.ToList();
        }
        
    }
}
