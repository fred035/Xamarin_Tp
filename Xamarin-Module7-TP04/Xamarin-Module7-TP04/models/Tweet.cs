using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Module7_TP04.models
{
    class Tweet
    {
        public String identifiants { get; set; }
        public String dateDeCreation { get; set; }
        public String texte { get; set; }
        public String nomUtilisateur { get; set; }
        public String idUtilisateur { get; set; }
        public String pseudoUtilisateur { get; set; }

        public Tweet(string identifiants, string dateDeCreation, string texte, string nomUtilisateur, string idUtilisateur, string pseudoUtilisateur)
        {
            this.identifiants = identifiants;
            this.dateDeCreation = dateDeCreation;
            this.texte = texte;
            this.nomUtilisateur = nomUtilisateur;
            this.idUtilisateur = idUtilisateur;
            this.pseudoUtilisateur = pseudoUtilisateur;
        }

        public Tweet()
        {
        }
    }
}
