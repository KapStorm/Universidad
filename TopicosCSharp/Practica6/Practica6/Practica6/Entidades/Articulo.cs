namespace Practica6.Entidades
{
    public class Articulo
    {
        public string ImgURL { get; }
        public string Nombre { get; }
        public double Precio { get; }
        public string PrecioConvertido => $"${Precio}";

        public Articulo(string imgURL, string nombre, double precio)
        {
            ImgURL = imgURL;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
