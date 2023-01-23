using LaCasa.View.Accueil;
using LaCasa.View.Accueil.AccueilPoseur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaCasa.View.Connexion.ConnexionEnseigne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginEnseigne : ContentPage
    {
        public LoginEnseigne()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtMail.Text == "a" && txtMdp.Text == "a")
            {
                var page = new AccueilP();
                Navigation.PushAsync(page);
                NavigationPage.SetHasNavigationBar(page, false);
            }
            else
            {
                DisplayAlert("Oups..", "Nom d'utilisateur ou mot de passe incorrect !", "Ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var page = new InscriptionE();
            Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
    }
}