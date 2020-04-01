using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Module8_TP05.Entities;

namespace Xamarin_Module8_TP05.Services
{
    public interface ITwitterService
    {
        String Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
