using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1_programacion_rad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInitialxaml : ContentPage
    {
        public PageInitialxaml()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagecontactos = new Views.Pagecontactos();
            Navigation.RemovePage(pagecontactos);

        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void listcontactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listcontactos.ItemsSource = await App.DBcontactos.GetLitsContacto();
        }
    }
}