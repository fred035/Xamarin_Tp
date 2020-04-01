using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Module7_TP04.Entities;

namespace Xamarin_Module7_TP04.Services
{
    public interface ITwitterService
    {
        String Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
