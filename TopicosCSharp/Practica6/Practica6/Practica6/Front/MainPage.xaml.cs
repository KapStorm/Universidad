using System;
using System.Collections.Generic;
using Practica6.Entidades;
using Practica6.Front;
using Xamarin.Forms;

namespace Practica6
{
    public partial class MainPage : ContentPage
    {
        private List<Articulo> carrito;

        public MainPage()
        {
            InitializeComponent();
            carrito = new List<Articulo>();
            lstVPersonajes.ItemsSource = new List<Articulo>
            {
                new Articulo("TWOK.png", "El Camino de los Reyes", 777.00),
                new Articulo("WOR.png", "Palabras Radiantes", 693.01),
                new Articulo("O.png", "Juramentada", 531.52),
                new Articulo("ROW.png", "El Ritmo de la Guerra", 772.99)
            };
        }

        private void lstVPersonajes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Articulo personaje = (Articulo) e.Item;
            DisplayAlert("Agregado", $"Libro {personaje.Nombre} agregado", "Agregado");
            carrito.Add(personaje);
        }

        private void btnCarrito_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageCarrito(carrito));
        }
    }
}
