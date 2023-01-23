using LaCasa.View.Inscription.InscriptionPoseur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaCasa.View.Inscription.InscriptionPoseur
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscriptionP5 : ContentPage
    {
        public InscriptionP5()
        {
            InitializeComponent();
        }
        private async void Follow_Clicked(object sender, EventArgs e)
        {
            var page = new InscriptionP6();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
    }
}