using ENI_Xamarin_30032020.Entities;
using ENI_Xamarin_30032020.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;
using static ENI_Xamarin_30032020.Configurations.ViewModelLocator;

namespace ENI_Xamarin_30032020.ViewModels
{
    public class ConnectionViewViewModel
    {
        private INavigationService navigation;
        private ITwitterService twitterService;

        public User User { get; set; }

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
        }
    }
}
