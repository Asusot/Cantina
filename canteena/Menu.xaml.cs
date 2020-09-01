using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace canteena
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MenuDetalhe());
        
        }


        private void GoContato(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page1());
            IsPresented = false;
        }
        private void GoSobreNos(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page2());
            IsPresented = false;
        }
        private void GoPage3(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page3());
            IsPresented = false;
        }
    }


}
