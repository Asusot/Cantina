using canteena.Aluno;
using canteena.Proprietario;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace canteena
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetalhe : ContentPage
    {
        public MenuDetalhe()
        {
            InitializeComponent();
        }

        private async void Btn_Cadastro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeAluno());
        }

        private async void Redirecionar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeProprietario());
        }


    }
}