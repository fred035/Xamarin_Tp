using ENI_Xamarin_30032020.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ENI_Xamarin_30032020.ViewModels
{
    public class TweetsViewViewModel : ViewModelBase
    {
        public StackLayout TweetContainer { get; set; }

        public TweetsViewViewModel()
        {
            MessengerInstance.Register<NotificationMessage>(this, NotifyMe);
        }

        public void NotifyMe(NotificationMessage notificationMessage)
        {
            string notification = notificationMessage.Notification;
            //do your work
        }
    }
}
