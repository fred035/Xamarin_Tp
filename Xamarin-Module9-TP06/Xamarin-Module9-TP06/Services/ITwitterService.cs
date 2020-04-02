using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Module9_TP06.Entities;

namespace Xamarin_Module9_TP06.Services
{
    public interface ITwitterService
    {
        String Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
