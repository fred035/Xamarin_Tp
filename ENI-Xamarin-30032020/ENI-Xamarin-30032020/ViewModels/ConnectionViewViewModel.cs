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

        public RelayCommand ConnectionClicked
        {
            get
            {
                return new RelayCommand(() =>
                {
                    this.navigation.NavigateTo(Pages.TweetsPage.ToString());
                });
            }
        }

        public ConnectionViewViewModel(INavigationService navigation)
        {
            this.navigation = navigation;
        }
    }
}
