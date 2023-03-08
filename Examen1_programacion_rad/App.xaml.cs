using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
namespace Examen1_programacion_rad
{
    public partial class App : Application
    {
        static Controllers.ContactosControllers dbcontacto;

        public static Controllers.ContactosControllers DBcontactos
        {
            get 
            {  
                if (dbcontacto == null)
                {
                    var dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Contactos.db3";
                    dbcontacto = new Controllers.ContactosControllers(Path.Combine(dbpath, dbname));
                }

                return dbcontacto;

            } 

            
        } 
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Pagecontactos());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
