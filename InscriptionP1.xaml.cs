using LaCasa.Services;
using LaCasa.View.Inscription.InscriptionPoseur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppAuth.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaCasa.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscriptionP1 : ContentPage
    {    
        // à revoir demain matin avec chatGPT//
        public InscriptionP1()
        {
            InitializeComponent();
            login.TextChanged += HandleTextChanged;
            password.TextChanged += HandleTextChanged;
        }

        private async void Follow_Clicked(object sender, EventArgs e)
        {
            /*var page = new InscriptionP2();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
            await progressBar1.ProgressTo(0.25, 1000, Easing.BounceIn);*/

            ApiServices apiServices = new ApiServices();
            var user = new AuthUserDto
            {
                Login = login.Text,
                Password = password.Text,
                //Name = name.Text,
                Token = ""
            };

            var response = await apiServices.RegisterUserAsync(Constants.Url + "/Register", user);

            if (response != null)
                await Navigation.PopAsync();
            else
                await DisplayAlert("Erreur !", "UserName ou Email déjà utilisé ou Password invalide", "OK");
        }   

        private void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isValid = !string.IsNullOrWhiteSpace(login.Text) && !string.IsNullOrWhiteSpace(password.Text);
            followBtn.IsEnabled = isValid;
            if (followBtn.IsEnabled)
            {
                followBtn.VerticalOptions = LayoutOptions.Center;
                followBtn.Text = "Poursuivre";
                followBtn.TextColor = Color.White;
                followBtn.BackgroundColor = Color.FromRgb(210, 10, 17);
                followBtn.BorderWidth = 1.5;
                followBtn.CornerRadius = 50;
                followBtn.Clicked += Follow_Clicked;
            }
        }

    }
}