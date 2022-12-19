using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Practica5
{
    public partial class MainPage : ContentPage
    {
        private int[] votos;
        private RadioButton rb;

        public MainPage()
        {
            InitializeComponent();
            votos = new int[4];
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            rb = (sender as RadioButton);
            mascota.Text = rb.Content.ToString();
        }

        private void btnEnviar_Clicked(object sender, System.EventArgs e)
        {
            int voto = Convert.ToInt32(rb.Value);
            votos[voto]++;
        }

        private void btnResultados_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Resultados(votos));
        }
    }
}
