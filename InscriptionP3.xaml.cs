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
    public partial class InscriptionP3 : ContentPage, IInscription
    {
        public InscriptionP3()
        {
            InitializeComponent();
        }
        private async void Follow_Clicked(object sender, EventArgs e)
        {
            var page = new InscriptionP4();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
        void IInscription.HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        bool IInscription.OnBackButtonPressed()
        {
            throw new NotImplementedException();
        }
    }
}