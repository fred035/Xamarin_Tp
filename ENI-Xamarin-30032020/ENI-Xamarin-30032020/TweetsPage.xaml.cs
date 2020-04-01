using ENI_Xamarin_30032020.Views;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ENI_Xamarin_30032020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsPage : MessengerContentPage
    {
        public TweetsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MessengerInstance.Send<GenericMessage<int>>(new GenericMessage<int>(99));
            base.OnAppearing();
        }
    }
}