using Practica6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica6.Front
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageCarrito : ContentPage
	{
		private Dictionary<Articulo, int> dict;

        public PageCarrito (List<Articulo> carrito)
		{
			InitializeComponent ();
			dict = carrito.GroupBy(x => x)
				.ToDictionary(keySelector: x => x.Key, elementSelector: x => x.Count());

			lstVCarrito.ItemsSource = dict.ToList().Select(x => {
				double total = x.Key.Precio * x.Value;
				return new Tuple<double, KeyValuePair<Articulo, int>>(total, x);
			});

			lblTotal.Text = dict.Sum(x => x.Key.Precio * x.Value).ToString();
		}
    }
}