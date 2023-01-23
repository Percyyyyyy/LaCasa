using LaCasa.View;
using LaCasa.View.Connexion.ConnexionEnseigne;
using LaCasa.View.Connexion.ConnexionPoseur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaCasa.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
        }



        private  async void LoginE_Clicked(object sender, EventArgs e)
        {
            var page = new LoginEnseigne();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }

        private async void LoginP_Clicked(object sender, EventArgs e)
        {
            var page = new LoginPoseur();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
    }
}