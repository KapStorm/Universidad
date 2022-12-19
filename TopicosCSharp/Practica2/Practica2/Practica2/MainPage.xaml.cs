using System;
using Xamarin.Forms;

namespace Practica2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            string nombre = entryNombre.Text;
            string edad = entryEdad.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edad)) {
                DisplayAlert("Error", "Campos vacios", "Ok");
                return;
            }

            salida.Text = Convert.ToInt32(edad) >= 18 
                ? $"{nombre} es mayor de edad" 
                : $"{nombre} es menor de edad";
        }
    }
}
