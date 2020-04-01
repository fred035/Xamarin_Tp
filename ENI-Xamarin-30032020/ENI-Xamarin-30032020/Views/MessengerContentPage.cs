using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ENI_Xamarin_30032020.Views
{
    public class MessengerContentPage : ContentPage
    {
        private IMessenger _messengerInstance;

        protected IMessenger MessengerInstance
        {
            get
            {
                return this._messengerInstance ?? Messenger.Default;
            }
            set
            {
                this._messengerInstance = value;
            }
        }
    }
}
