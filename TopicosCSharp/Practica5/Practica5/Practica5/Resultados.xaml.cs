using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultados : ContentPage
    {
        public Resultados(int[] votos)
        {
            InitializeComponent();
            lblPerros.Text = $"Votos perros: {votos[0]}";
            lblGatos.Text = $"Votos gatos: {votos[1]}";
            lblTortugas.Text = $"Votos tortugas: {votos[2]}";
            lblConejos.Text = $"Votos conejos: {votos[3]}";

            int ganador = Ganador(votos);
            lblGanador.Text = "El ganador es: ";
            switch (ganador)
            {
                case 0:
                    lblGanador.Text += "perro";
                    break;
                case 1:
                    lblGanador.Text += "gato";
                    break;
                case 2:
                    lblGanador.Text += "tortuga";
                    break;
                case 3:
                    lblGanador.Text += "conejo";
                    break;
            }

            if (Repetido(votos)) 
                lblGanador.Text = "No hubo ganador, hay empate";
        }

        private int Ganador(int[] votos)
        {
            int indx = 0;
            
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[indx] < votos[i])
                    indx = i;
            }

            return indx;
        }

        private bool Repetido(int[] votos)
        {
            Array.Sort(votos);
            Array.Reverse(votos);
            return votos[0] == votos[1];
        }
    }
}