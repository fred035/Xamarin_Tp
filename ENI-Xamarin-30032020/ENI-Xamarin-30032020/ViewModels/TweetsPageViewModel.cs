using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENI_Xamarin_30032020.ViewModels
{
    public class TweetsPageViewModel : ViewModelBase
    {
        private INavigationService navigation;

        public TweetsPageViewModel(INavigationService navigation)
        {
            this.navigation = navigation;
        }
    }
}
