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
            Messenger.Default.Register<GenericMessage<StackLayout>>(this, NotifyMe);
        }

        public void NotifyMe(GenericMessage<StackLayout> msg)
        {
            for (int i = 0; i < 10; i++)
            {
                msg.Content.Children.Add(new OneTweetView());
            }
        }
    }
}
