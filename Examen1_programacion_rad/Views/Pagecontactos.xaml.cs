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
    public partial class Pagecontactos : ContentPage
    {
        public Pagecontactos()
        {
            InitializeComponent();
        }

        private async void Btnsalvar_Clicked(object sender, EventArgs e)
        {
            var contactos = new Models.Contactos
            {
                Nombre = txtnombre.Text,
                Telefono = txttelefono.Text,
                Edad = txtedad.Text,
                Pais = cbpais.SelectedItem.ToString(),
                Nota = txtnota.Text,  

                

            };

            if (await App.DBcontactos.SaveContacto(contactos) > 0)
                await DisplayAlert("Alerta", "Contanto Ingresado", "OK");
            else
                await DisplayAlert("Alerta", "Error", "OK");
            



                var page = new Views.PageResultado();
            page.BindingContext = contactos;
            await Navigation.PushAsync(page);


        }
    }
}