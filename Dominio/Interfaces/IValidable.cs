namespace Dominio.Interfaces
{
    /// Interfaz para validar objetos del dominio
    public interface IValidable
    {
        /// Valida el objeto según sus reglas de negocio
        void Validar();
    }
}
