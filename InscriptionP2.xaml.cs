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
    public partial class InscriptionP2 : ContentPage
    {
        public InscriptionP2()
        {
            InitializeComponent();
        }
        private async void Follow_Clicked(object sender, EventArgs e)
        {
            var page = new InscriptionP3();         
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PopAsync();
            //InscriptionP1.progressBar1.Progress -= 0.125;
            return true;
        }
    }
}