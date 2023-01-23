using LaCasa.Services;
using LaCasa.View.Accueil;
using LaCasa.View.Accueil.AccueilPoseur;
using LaCasa.View.Inscription.InscriptionPoseur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppAuth.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaCasa.View.Connexion.ConnexionPoseur
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPoseur : ContentPage
    {
        public LoginPoseur()
        {
            InitializeComponent();
        }

        async void LoginP_Clicked(object sender, EventArgs e)
        {
            ApiServices apiServices = new ApiServices();
            var user = new AuthUserDto
            {
                Login = login.Text,
                Password = password.Text,

                Token = ""
            };
            var token = await apiServices.LoginUserAsync(Constants.Url, user);
            if(token != "")
            {
                var page = new AccueilP();
                NavigationPage.SetHasNavigationBar(page, false);
                await Navigation.PushAsync(page);

            }
            else
            {
                await DisplayAlert("Erreur !", "Login ou mdp invalide", "OK");
            }
        }
    }
}