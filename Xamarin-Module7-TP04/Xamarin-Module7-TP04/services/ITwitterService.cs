using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Module7_TP04.models;

namespace Xamarin_Module7_TP04.services
{
    interface ITwitterService
    {
        Boolean authenticate(String utilisateur, String motDePasse);
        List<Tweet> GetTweets(String msg);
    }
}
