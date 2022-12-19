using Xamarin.Forms;

namespace Practica4
{
    public partial class App : Application
    {
        public string textoAMostrar = "textoAMostrar";
        public string TextoAMostrar { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        // Metodo que se ejecuta SOLO si la App se acaba de inicializar
        protected override void OnStart()
        {
            MainPage.DisplayAlert("Anuncio", "OnStart | Al iniciar la App", "Ok");

            // Acá cargaremos el 'textoAMostrar' que se almacenó en memoria
            if (Properties.ContainsKey(textoAMostrar))
            {
                TextoAMostrar = Properties[textoAMostrar].ToString();
            }
        }

        // Metodo que se ejecuta al momento de minimizar la App. Cuando está dormida la App
        protected override void OnSleep()
        {
            MainPage.DisplayAlert("Anuncio", "OnSleep | Al minimizar la App", "Ok");

            // Cuando se duerme, asignamos a la memoria el 'textoAMostrar'
            Properties[textoAMostrar] = TextoAMostrar;
        }

        // Metodo que se ejecuta después de regresar a la App que estaba en el estado OnSleep
        protected override void OnResume()
        {
            MainPage.DisplayAlert("Anuncio", "OnResume | Al volver a la App", "Ok");
        }
    }
}
