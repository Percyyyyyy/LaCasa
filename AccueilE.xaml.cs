using LaCasa.Services;
using LaCasa.View.Connexion.ConnexionEnseigne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaCasa.View.Accueil.AccueilEnseigniste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccueilE : TabbedPage
    {
        private readonly HttpClient _client = new HttpClient();

        public AccueilE()
        {
            InitializeComponent();
            if (CurrentpropertiesService.IsAuth())
                DisplayAlert("", "Bienvenue " + CurrentpropertiesService.GetName(), "Merci !");
            else
            {
                DisplayAlert("", "Veuillez vous identifier", "Très bien.");
                Navigation.PushAsync(new RootPage());
            }
        }
        protected async override void OnAppearing()
        {
            /*base.OnAppearing();
            if (CurrentpropertiesService.IsAuth())
            {
                await DisplayAlert("", "Bienvenue " + CurrentpropertiesService.GetName(), "Merci !");
                // réccupère les données de températures
                ApiServices apiServices = new ApiServices();
                var data = await apiServices.GetTempAsync(Constants.UrlTemp, CurrentpropertiesService.GetToken());
                if (data.Count != 0)
                    listeTemp.ItemsSource = data;
                else
                {
                    // si le token n'est plus valide
                    await Navigation.PushAsync(new AuthenticationPage());
                }
                
            }
            else
            {
                    
                label.Text = "Veuillez vous identifier";
                log.Text = "Login";
                listeTemp.ItemsSource = null;
            }*/
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListeRDV());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
        }

        private async void settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginEnseigne());

        }
    }
}