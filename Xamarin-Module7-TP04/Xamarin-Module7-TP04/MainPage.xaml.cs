using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Module7_TP04.services;

namespace Xamarin_Module7_TP04
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
            this.btnConnexion.Clicked += BtnConnexion_Clicked;
            this.errorLabel.IsVisible = false;
            this.tweetList.IsVisible = false;
        }

        private void BtnConnexion_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("btn clicked");
            String login = this.identifiant.Text;
            String password = this.motDePasse.Text;
            Boolean isRemind = this.memorise.IsToggled;

            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(login) || login.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant ne peut pas être null et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                stringBuilder = appendNewLine(haveError, stringBuilder);
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être null et doit posséder au moins 6 caractères.");
            }

            if (!haveError && !this.twitterService.authenticate(login, password))
            {
                haveError = true;
                stringBuilder.Append("Le nom ou le mot de passe est incorrect.");
            }

            if (haveError)
            {
                this.errorLabel.Text = stringBuilder.ToString();
                this.errorLabel.IsVisible = true;
            }
            else
            {
                this.errorLabel.Text = "";
                this.errorLabel.IsVisible = false;
                this.connectionForm.IsVisible = false;
                this.tweetList.IsVisible = true;
            }
        }

        private StringBuilder appendNewLine(Boolean haveError, StringBuilder stringBuilder)
        {
            if (haveError)
            {
                stringBuilder.Append("\n");
            }
            return stringBuilder;
        }

    }
}
