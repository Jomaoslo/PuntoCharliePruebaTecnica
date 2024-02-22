namespace PuntoCharliePruebaTecnica.Apis.Models
{
    /// Entidad para almacenar los procesos para validar si existen o no errores
    public class Response
    {
        public bool State { get; set; }
        public string Code { get; set; }
        public string Messsage { get; set; }    
    }
}