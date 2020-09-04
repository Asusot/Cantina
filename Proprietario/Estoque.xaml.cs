using System;
using System.Collections.Generic;
using canteena.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace canteena.Proprietario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Estoque : ContentPage
    {



        public Estoque()
        {
            InitializeComponent();

            lv1.ItemsSource = new List<Produto>
              { new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                   new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" },
                  new Produto {Nome ="Coxinha top",Valor=28.69,ImgUrl="https://images.rappi.com.br/products/e252ed89-141d-49de-bf2a-a2ddfd8cdd71-1592578128624.jpeg?d=128x90"},

                  new Produto {Nome ="Pastel top",Valor=12.69,ImgUrl="https://images.rappi.com.br/restaurants_background/pastel-da-mi-home1-1568221061886.png?d=200x200" }
              };
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }




        private async void BtnCadastroItem(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuDetalhe());
        }
    }
}
