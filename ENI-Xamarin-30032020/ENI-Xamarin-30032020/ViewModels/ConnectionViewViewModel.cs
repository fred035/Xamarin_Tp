using ENI_Xamarin_30032020.Entities;
using ENI_Xamarin_30032020.Models;
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
    public class ConnectionViewViewModel
    {
        private INavigationService navigation;
        private ITwitterService twitterService;

        public User User { get; } = new User();
        public ErrorSwitch ErrorSwitch { get; } = new ErrorSwitch() { ErrorColor = "red" };

        public RelayCommand ConnectionClicked
        {
            get
            {
                return new RelayCommand(() =>
                {
                    String errors = this.twitterService.Authenticate(User);
                    if (String.IsNullOrEmpty(errors))
                    {
                        this.ErrorSwitch.ErrorText = "";
                        this.ErrorSwitch.IsErrorVisible = false;

                        this.navigation.NavigateTo(Pages.TweetsPage.ToString());
                    }
                    else
                    {
                        this.ErrorSwitch.ErrorText = errors;
                        this.ErrorSwitch.IsErrorVisible = true;
                    }
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
