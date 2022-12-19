using System;
using Xamarin.Forms;

namespace Practica4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al momento de que aparezca la página
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Obtenemos el 'TextoAMostrar' y se lo asignamos al Entry
            entryInput.Text = (Application.Current as App).TextoAMostrar;
        }

        // Metodo que se ejecuta cuando se termina de escribir en el Entry
        private void OnEntryCompleted(object sender, EventArgs e)
        {
            // Guarda en la memoria el texto del entry
            (Application.Current as App).TextoAMostrar = entryInput.Text;
        }
    }
}
