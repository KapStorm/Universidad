/*
 * Hecho por: Arellanes Beltran Sebastian
 */
namespace CatalogoDeServicios
{
    internal class Program
    {
        // Atributo de presenta catalogo
        private PresentaCatalogo presenta;

        // Constructor para incializar el presenta
        public Program()
        {
            AdministraCatalogo admin = new AdministraCatalogo();
            presenta = new PresentaCatalogo(admin);
        }
        
        public static void Main(string[] args)
        {
            // Instanciamos programa
            Program p = new Program();
            // Invocamos menu
            p.presenta.Menu();
        }
    }
}