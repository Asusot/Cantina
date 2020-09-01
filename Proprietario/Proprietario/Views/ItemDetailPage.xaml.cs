using System.ComponentModel;
using Xamarin.Forms;
using Proprietario.ViewModels;

namespace Proprietario.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}