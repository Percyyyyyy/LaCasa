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
    public partial class InscriptionP4 : ContentPage
    {
        public InscriptionP4()
        {
            InitializeComponent();
        }
        private async void Follow_Clicked(object sender, EventArgs e)
        {
            var page = new InscriptionP5();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
    }
}