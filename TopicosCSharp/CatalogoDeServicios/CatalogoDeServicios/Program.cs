using System;

namespace CatalogoDeServicios
{
    internal class Program
    {
        private PresentaCatalogo presenta;

        public Program()
        {
            AdministraCatalogo admin = new AdministraCatalogo();
            presenta = new PresentaCatalogo(admin);
        }
        
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.presenta.Menu();
        }
    }
}