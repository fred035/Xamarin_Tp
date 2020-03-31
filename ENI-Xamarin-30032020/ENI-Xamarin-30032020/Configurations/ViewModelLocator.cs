using CommonServiceLocator;
using ENI_Xamarin_30032020.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENI_Xamarin_30032020.Configurations
{
    public class ViewModelLocator
    {
        public enum Pages
        {
            MainPage,
            TweetsPage
        }

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<INavigationService>(() =>
            {
                var navigationService = NavigationService.Instance;
                navigationService.Configure(Pages.MainPage.ToString(), typeof(MainPage));
                navigationService.Configure(Pages.TweetsPage.ToString(), typeof(TweetsPage));
                return navigationService;
            });

            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<ConnectionViewViewModel>();
        }


        public MainPageViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }

        public ConnectionViewViewModel ConnectionViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ConnectionViewViewModel>();
            }
        }
        
    }
}
