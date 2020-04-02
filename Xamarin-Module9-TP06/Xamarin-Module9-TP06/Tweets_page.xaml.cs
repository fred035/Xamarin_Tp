using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Module9_TP06.Entities;

namespace Xamarin_Module9_TP06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tweets_page : ContentPage
    {
        ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
        public Tweets_page()
        {
            InitializeComponent();
            this.tweets.Add(new Tweet { 
                User = new User { Login = "Antoine", Password = "1234" }, 
                Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec euismod convallis dolor.Quisque ultricies porttitor nunc venenatis facilisis.", 
                CreatedAt= new DateTime() });
            this.ListeTweets.ItemsSource = this.tweets;
        }
    }
}