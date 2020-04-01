using ENI_Xamarin_30032020.Entities;
using ENI_Xamarin_30032020.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static ENI_Xamarin_30032020.Configurations.ViewModelLocator;

namespace ENI_Xamarin_30032020.ViewModels
{
    public class ConnectionViewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private INavigationService navigation;
        private ITwitterService twitterService;

        private User user;

        public User User
        {
            get { return user; }
            set 
            { 
                user = value;
                OnPropertyChanged("User");
            }
        }


        public RelayCommand ConnectionClicked
        {
            get
            {
                return new RelayCommand(() =>
                {
                    this.twitterService.Authenticate(User);
                    this.navigation.NavigateTo(Pages.TweetsPage.ToString());
                });
            }
        }

        public ConnectionViewViewModel(INavigationService navigation, ITwitterService twitterService)
        {
            this.navigation = navigation;
            this.twitterService = twitterService;
            this.user = new User();
        }
    }
}
