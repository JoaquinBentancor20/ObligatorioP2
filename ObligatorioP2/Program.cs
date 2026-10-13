using Dominio;

namespace ObligatorioP2
{ 
    
    public class Program
    {
        static void Main(string[] args)
        {

            Sistema sistema = Sistema.Instancia;
            Precarga.CargarDatos(sistema);
            
        }
    }

}
    

