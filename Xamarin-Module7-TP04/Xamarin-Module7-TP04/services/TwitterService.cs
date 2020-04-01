using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Module7_TP04.models;

namespace Xamarin_Module7_TP04.services
{
    class TwitterService : ITwitterService
    {

        public bool authenticate(string utilisateur, string motDePasse)
        {
            String utilisateurFake = "pierre";
            String motDePasseFake = "000000";

            if (utilisateur.Equals(utilisateurFake) && motDePasse.Equals(motDePasseFake))
            {
                return true;
            }
            return false;
        }

        public List<Tweet> GetTweets(string msg)
        {
            List<Tweet> listeTweets = new List<Tweet>();
            Tweet mytweet = new Tweet("0", "mars 2020", msg, "pierre", "0", "toto");

            listeTweets.Add(mytweet);
            return listeTweets;
        }

    }
}
