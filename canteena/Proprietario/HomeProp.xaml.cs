using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace canteena.Proprietario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeProp : ContentPage
    {
        public HomeProp()
        {
            InitializeComponent();
        }

        private async void Btn_Pedidos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pedidos());
        }
        private async void Btn_Fluxo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FluxoCaixa());
        }

        
        private async void Btn_Estoque(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estoque());
        }

        private async void Btn_Clientes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Clientes());
        }
    }
}